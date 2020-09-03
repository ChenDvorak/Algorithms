using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArray2Test
    {
        [TestMethod]
        public void TestRemoveDuplicatesFromSortedArray2()
        {
            var f = new Algorithms.LeetCode.RemoveDuplicatesFromSortedArray2();
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var length = f.Run(nums);
            nums = nums[..length];
            Assert.AreEqual(length, 5);
            Assert.IsTrue(nums.SequenceEqual(new int[] { 1, 1, 2, 2, 3 }));

            nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            length = f.Run(nums);
            nums = nums[..length];
            Assert.AreEqual(length, 7);
            Assert.IsTrue(nums.SequenceEqual(new int[] { 0, 0, 1, 1, 2, 3, 3 }));

        }
    }
}