using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class ContainerWithMostWaterTest
    {
        [TestMethod]
        public void TestContainerWithMostWater()
        {
            var f = new Algorithms.LeetCode.ContainerWithMostWater();
            Assert.AreEqual(f.Run(new int[]{ 1, 8, 6, 2, 5, 4, 8, 3, 7 }), 49);
        }
    }
}