using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class RotateImageTest
    {
        [TestMethod]
        public void TestRotateImage()
        {
            var f = new Algorithms.LeetCode.RotateImage();
            int[][] matrix = new int[][] {
                new int[] { 5, 1, 9, 11},
                new int[] {2, 4, 8, 10},
                new int[] {13, 3, 6, 7},
                new int[] { 15, 14, 12, 16}
            };
            var answer = f.Run(matrix);
            foreach (var row in answer)
            {
                foreach (var column in row)
                {
                    Console.Write($"{column} ");
                }
                Console.WriteLine();
            }
        }
    }
}