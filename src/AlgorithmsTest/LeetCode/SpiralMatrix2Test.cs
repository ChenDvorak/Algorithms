using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SpiralMatrix2Test
    {
        [TestMethod]
        public void TestSpiralMatrix2()
        {
            const int N = 3;
            var f = new Algorithms.LeetCode.SpiralMatrix2();
            var matrix = f.Run(N);

            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "  ");

                }
                Console.WriteLine();
            }
        }
    }
}