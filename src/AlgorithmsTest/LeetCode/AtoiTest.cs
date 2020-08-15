using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class AtoiTest
    {
        [TestMethod]
        public void TestAtoi()
        {
            var f = new Algorithms.LeetCode.Atoi();
            Assert.AreEqual(f.Run("123"), 123);
            Assert.AreEqual(f.Run("-123"), -123);
            Assert.AreEqual(f.Run(" -123"), -123);
            Assert.AreEqual(f.Run("w-123"), 0);
            Assert.AreEqual(f.Run("12w3"), 12);
            Assert.AreEqual(f.Run("21474836471"), int.MaxValue);
            Assert.AreEqual(f.Run("-21474836471"), int.MinValue);
        }
    }
}