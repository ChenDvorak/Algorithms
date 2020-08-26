using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class PermutationsTest
    {
        [TestMethod]
        public void TestPermutations()
        {
            var f = new Algorithms.LeetCode.Permutations();
            var answers = f.Run(new int[] { 1, 2, 3 });
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