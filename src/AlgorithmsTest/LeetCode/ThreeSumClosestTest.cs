using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class ThreeSumClosestTest
    {
        [TestMethod]
        public void TestThreeSumClosest()
        {
            var f = new Algorithms.LeetCode.ThreeSumClosest();
            Assert.AreEqual(f.Run(new int[] { -1, 2, 1, -4 }, 1), 2);
        }
    }
}