using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class ReverseIntegerTest
    {
        public void TestReverseInteger()
        {
            var f = new LeetCode.ReverseInteger();
            var reverseValue = f.Run(-123456);
            Console.WriteLine($"Reverse Value is: {reverseValue}");
        }
    }
}