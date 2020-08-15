using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class FourSumTest
    {
        [TestMethod]
        public void TestFourSum()
        {
            var f = new Algorithms.LeetCode.FourSum();
            var answers = f.Run(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
        }
    }
}