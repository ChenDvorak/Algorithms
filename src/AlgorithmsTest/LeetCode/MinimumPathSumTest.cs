using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class MinimumPathSumTest
    {
        [TestMethod]
        public void TestMinimumPathSum()
        {
            int[][] grid = new int[][]
            {
                new int[] { 1, 3, 1 },
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            };

            var f = new Algorithms.LeetCode.MinimumPathSum();
            Assert.AreEqual(f.Run(grid), 7);
        }
    }
}