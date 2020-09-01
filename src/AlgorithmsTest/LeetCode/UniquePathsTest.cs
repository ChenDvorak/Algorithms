using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class UniquePathsTest
    {
        [TestMethod]
        public void TestUniquePaths()
        {
            var f = new Algorithms.LeetCode.UniquePaths();
            int answer = f.Run(3, 2);
            Console.WriteLine(answer);
            Assert.AreEqual(answer, 3);
            answer = f.Run(7, 3);
            Console.WriteLine(answer);
            Assert.AreEqual(answer, 28);
        }
    }
}