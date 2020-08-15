using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class PalindromeNumber
    {
        [TestMethod]
        public void TestPalindromeNumber()
        {
            var f = new Algorithms.LeetCode.PalindromeNumber();
            f.Run(123456);
        }
    }
}