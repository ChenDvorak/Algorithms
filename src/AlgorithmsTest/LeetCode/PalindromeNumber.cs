using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class PalindromeNumber
    {
        public void TestPalindromeNumber()
        {
            var f = new LeetCode.PalindromeNumber();
            f.Run(123456);
        }
    }
}