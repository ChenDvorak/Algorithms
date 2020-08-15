using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class ThreeSumTest
    {
        [TestMethod]
        public void TestThreeSum()
        {
            var f = new Algorithms.LeetCode.ThreeSum();
            var answer = f.Run(new int[] { -1, 0, 1, 2, -1, -4 });
        }
    }
}