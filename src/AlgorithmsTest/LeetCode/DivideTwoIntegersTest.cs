using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class DivideTwoIntegersTest
    {
        [TestMethod]
        public void TestDivideTwoIntegers()
        {
            var f = new Algorithms.LeetCode.DivideTwoIntegers();
            int quotient = f.Run(10, 3);
            Console.WriteLine(quotient);
            Assert.AreEqual(quotient, 3);
            quotient = f.Run(7, -3);
            Console.WriteLine(quotient);
            Assert.AreEqual(quotient, -2);
        }
    }
}