using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class WordSearchTest
    {
        [TestMethod]
        public void TestWordSearch()
        {
            char[][] grid = new char[][]
            {
                new char[] {'A', 'B', 'C', 'E' },
                new char[] {'S', 'F', 'C', 'S'},
                new char[] {'A', 'D', 'E', 'E'}
            };

            var f = new Algorithms.LeetCode.WordSearch();
            Assert.IsTrue(f.Run(grid, "ABCCED"));
            f = new Algorithms.LeetCode.WordSearch();
            Assert.IsTrue(f.Run(grid, "SEE"));
            f = new Algorithms.LeetCode.WordSearch();
            Assert.IsFalse(f.Run(grid, "ABCB"));
        }
    }
}