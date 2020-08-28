using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SpiralMatrixTest
    {
        [TestMethod]
        public void TestSpiralMatrix()
        {
            int[][] nums = new int[][] {
                new int []{1, 2, 3 },
                new int []{4, 5, 6},
                new int []{7, 8, 9}
            };

            var f = new Algorithms.LeetCode.SpiralMatrix();
            var answer = f.Run(nums);
            foreach (var v in answer)
            {
                Console.Write($"{v} ");
            }
            Assert.IsTrue(answer.SequenceEqual(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }));
        }
    }
}