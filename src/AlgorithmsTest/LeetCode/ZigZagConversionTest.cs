using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class ZigZagConversionTest
    {
        [TestMethod]
        public void TestZigZagConversion()
        {
            var f = new Algorithms.LeetCode.ZigZagConversion();
            Assert.AreEqual(f.Run("PAYPALISHIRING", 3), "PAHNAPLSIIGYIR");
        }
    }
}