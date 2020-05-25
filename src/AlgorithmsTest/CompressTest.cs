using Algorithms.Compress;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest
{
    /// <summary>
    /// 测试压缩
    /// </summary>
    [TestClass]
    public class CompressTest
    {
        const string PATH = ".\\wait_to_compress.txt";

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestCompress()
        {
            RLE rle = new RLE();
            rle.Compress(PATH);
        }
    }
}
