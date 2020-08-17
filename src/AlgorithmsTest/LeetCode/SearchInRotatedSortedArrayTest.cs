using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SearchInRotatedSortedArrayTest
    {
        [TestMethod]
        public void TestSearchInRotatedSortedArray()
        {
            var f = new Algorithms.LeetCode.SearchInRotatedSortedArray();
            var index = f.Run(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            Console.WriteLine(index);
            Assert.AreEqual(index, 4);
            index = f.Run(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
            Console.WriteLine(index);
            Assert.AreEqual(index, -1);
        }
    }
}