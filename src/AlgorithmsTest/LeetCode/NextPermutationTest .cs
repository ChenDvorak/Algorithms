using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class NextPermutationTest
    {
        [TestMethod]
        public void TestNextPermutation()
        {
            var f = new Algorithms.LeetCode.NextPermutation();
            int[] nums = { 1, 2, 3 };
            f.Run(nums);
            Assert.IsTrue(nums.SequenceEqual(new int[] { 1, 3, 2 }));

            int[] nums1 = { 1, 2, 3, 8, 5, 7, 6, 4 };
            f.Run(nums1);
            Assert.IsTrue(nums1.SequenceEqual(new int[] { 1, 2, 3, 8, 6, 4, 5, 7 }));
        }
    }
}