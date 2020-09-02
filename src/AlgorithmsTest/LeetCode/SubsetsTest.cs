using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SubsetsTest
    {
        [TestMethod]
        public void TestSubsets()
        {
            var f = new Algorithms.LeetCode.Subsets();
            var answers = f.Run(new int[] { 1, 2, 3 });
            Assert.AreEqual(answers.Count, 8);
        }
    }
}