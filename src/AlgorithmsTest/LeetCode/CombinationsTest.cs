using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class CombinationsTest
    {
        [TestMethod]
        public void TestCombinations()
        {
            var f = new Algorithms.LeetCode.Combinations();
            var answers = f.Run(4, 2);

        }
    }
}