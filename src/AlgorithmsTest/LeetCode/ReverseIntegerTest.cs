using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class ReverseIntegerTest
    {
        [TestMethod]
        public void TestReverseInteger()
        {
            var f = new Algorithms.LeetCode.ReverseInteger();
            var reverseValue = f.Run(-123456);
            Console.WriteLine($"Reverse Value is: {reverseValue}");
        }
    }
}