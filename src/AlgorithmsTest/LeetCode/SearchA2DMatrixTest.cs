using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SearchA2DMatrixTest
    {
        [TestMethod]
        public void TestSearchA2DMatrix()
        {
            int[][] matrix = new int[][]
                {
                    new int[] {1, 3, 5, 7 },
                    new int[] {10, 11, 16, 20 },
                    new int[] {23, 30, 34, 50}
                };

            var f = new Algorithms.LeetCode.SearchA2DMatrix();
            Assert.IsTrue(f.Run(matrix, 3));
            Assert.IsFalse(f.Run(matrix, 2));
        }
    }
}