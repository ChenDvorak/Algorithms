/*
 * rle compress algorithm
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Algorithms.Compress
{
    public class RLE
    {
        private const int FLAG_MAX_BYTE_COUNT = 0x7F;

        /// <summary>
        /// compress file and out put at current path
        /// </summary>
        /// <param name="sourcePath">file</param>
        public void Compress(string sourcePath)
        {
            using var sourceFile = File.OpenRead(sourcePath);
            var dirPath = sourcePath.Remove(sourcePath.LastIndexOf('\\'));
            var sourceExtension = Encoding.Default.GetBytes(Path.GetExtension(sourcePath));
            var outPutFileName = Path.GetFileNameWithoutExtension(sourcePath);
            //  输出的压缩文件
            using var outPutFile = File.Create(Path.Combine(dirPath, outPutFileName + "_compress.txt"));
            //  写入源文件的扩展名，格式 [扩展名字节数][扩展名字节数长度的字节段]
            outPutFile.WriteByte((byte)sourceExtension.Length);
            outPutFile.Write(sourceExtension, 0, sourceExtension.Length);

            //  指向文件字节位置
            int current = 0;

            byte[] value = new byte[1];

            while (current < sourceFile.Length - 1)
            {
                //  如果接下来的字节段是重复的
                if (IsRepeat(sourceFile, current, out byte[] count))
                {
                    sourceFile.Position = current;
                    sourceFile.Read(value, 0, 1);
                    outPutFile.WriteByte(count[0]);
                    outPutFile.WriteByte(value[0]);
                    //  这里是因为如果接下来是重复数据的话，最高为会是 1
                    //  所以要讲最高位置0，才能得到真实的重复数量
                    current += count[0] ^= 0x80;
                }
                else
                {
                    var notRepeatDatas = GetNotRepeatBytes(sourceFile, current);
                    foreach (byte data in notRepeatDatas)
                    {
                        outPutFile.WriteByte(data);
                    }
                    current += notRepeatDatas.Length;
                }
            }

        }

        /// <summary>
        /// the next byte is repeat byte of file, 
        /// only the least three bytes of data are the same is repeated
        /// </summary>
        /// <param name="file"></param>
        /// <param name="current"></param>
        /// <returns>(bool: is repeat, int: repeat count)</returns>
        private bool IsRepeat(FileStream file, int current, out byte[] count)
        {
            count = new byte[1] { 1 };

            byte[] startValue = new byte[1];
            byte[] tempValue = new byte[1];

            file.Position = current;
            if (file.Read(startValue, 0, 1) == 0)
                return false;

            for (int i = 1; i <= FLAG_MAX_BYTE_COUNT; i++)
            {
                file.Position = current + i;
                if (file.Read(tempValue, 0, 1) == 0 || startValue[0] != tempValue[0])
                    break;
                count[0]++;
            }
            if (count[0] > 3)
            {
                //  如果是重复的数据，在最高位用 1 标识
                //  像有接下来3个字节是重复的，转换为二进制就是 10000010
                //  其中的最高位是 1，用于标识是重复的数据
                //  因为最高位被占用，所以所以最高只能标识
                count[0] |= 0x80;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取接下来不重复的字节段
        /// </summary>
        /// <param name="file"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        private byte[] GetNotRepeatBytes(FileStream file, int current)
        {
            Stack<byte> notRepeatDatas = new Stack<byte>(FLAG_MAX_BYTE_COUNT / 2);

            byte[] firstData = new byte[1];
            byte[] tempData = new byte[1];

            int repeatCount = 0;

            for (int i = 1; i <= FLAG_MAX_BYTE_COUNT; i++)
            {
                file.Position = current;
                if (file.Read(firstData, 0, 1) == 0)
                    return new byte[0];

                file.Position = current + i;
                if (file.Read(tempData, 0, 1) == 0)
                    break;

                if (firstData[0] == tempData[0])
                    repeatCount++;
                else
                    repeatCount = 0;
                //  如果接下来是重复数据了，将重复数据去除
                if (repeatCount > 2)
                {
                    for (int j = 0; j < repeatCount - 1; j++)
                        notRepeatDatas.Pop();
                    repeatCount = 0;
                }
                else
                    notRepeatDatas.Push(tempData[0]);

            }
            return notRepeatDatas.ToArray();
        }

        //public async Task Decompression()
        //{

        //}
    }
}
