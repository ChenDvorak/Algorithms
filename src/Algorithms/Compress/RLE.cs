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
        private const int EOF = -1;

        /// <summary>
        /// compress file and out put at current path
        /// </summary>
        /// <param name="sourcePath">file</param>
        public async Task Compress(string sourcePath)
        {
            await using var sourceFile = File.OpenRead(sourcePath);
            var dirPath = Path.GetFullPath(sourcePath, "");
            var outPutFileName = Path.GetFileNameWithoutExtension(sourcePath);
            var outPutFileExtension = Path.GetExtension(sourcePath);
            var outPutFile = File.Create(Path.Combine(dirPath, outPutFileName + outPutFileExtension));

            int current = 0;

            byte[] value = new byte[1];


        }

        /// <summary>
        /// the next byte is repeat byte of file, 
        /// only the least three bytes of data are the same is repeated
        /// </summary>
        /// <param name="file"></param>
        /// <param name="current"></param>
        /// <returns>(bool: is repeat, int repeat count)</returns>
        private (bool, int) IsRepeat(FileStream file, int current)
        {
            int count = 1;

            return (false, 0);
        }
    }
}
