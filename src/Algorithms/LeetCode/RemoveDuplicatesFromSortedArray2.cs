/*
 *  remove duplicates from sorted array 2
 *  given a sorted array nums, remove the duplicates in-place such that duplicates appeared at most twice and return the new length.
 *  do net allocate extra space for another array.
 *  you must do this by modifying the input array in-place with O(1) extra memory.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    public class RemoveDuplicatesFromSortedArray2
    {
        public int Run(int[] nums)
        {
            if (nums.Length < 3)
                return nums.Length;
            int i = 2;
            for (int j = 2; j < nums.Length; j++)
            {
                if (nums[j] != nums[i - 2])
                    nums[i++] = nums[j];
            }
            return i;
        }
    }
}
