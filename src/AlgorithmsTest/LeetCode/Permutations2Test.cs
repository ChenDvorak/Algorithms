using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class Permutations2Test
    {
        [TestMethod]
        public void TestPermutations2()
        {
            var f = new Algorithms.LeetCode.Permutations2();
            var answers = f.Run(new int[] { 1, 1, 3 });
            answers.ForEach(item =>
            {
                item.ForEach(v =>
                {
                    Console.Write(v + " ");
                });
                Console.WriteLine();
            });
        }
    }
}