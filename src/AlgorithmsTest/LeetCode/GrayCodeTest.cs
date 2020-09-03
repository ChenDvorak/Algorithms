using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class GrayCodeTest
    {
        [TestMethod]
        public void TestGrayCode()
        {
            var f = new Algorithms.LeetCode.GrayCode();
            var answer = f.Run(2);
            Assert.AreEqual(answer.Count, 4);
        }
    }
}