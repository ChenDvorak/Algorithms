using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class JumpGameTest
    {
        [TestMethod]
        public void TestJumpGame()
        {
            var f = new Algorithms.LeetCode.JumpGame();
            Assert.IsTrue(f.Run(new int[] { 2, 3, 1, 1, 4 }));
            Assert.IsFalse(f.Run(new int[] { 3, 2, 1, 0, 4 }));
        }
    }
}