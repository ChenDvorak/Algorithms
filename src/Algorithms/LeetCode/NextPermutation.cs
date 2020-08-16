/*
 * next permutation
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class NextPermutation
    {
        public void Run(int[] nums)
        {
            if (nums.Length < 1)
                return;
            int i = nums.Length - 2,
                j = nums.Length - 1,
                k = nums.Length - 1;
            while (i >= 0 && nums[i] > nums[j])
            {
                i--;
                j--;
            }
            if (i >= 0)
            {
                while (nums[i] >= nums[k])
                    k--;
                var temp = nums[i];
                nums[i] = nums[k];
                nums[k] = temp;
            }

            for (int a = j, b = nums.Length - 1; a < b; a++, b--)
            {
                var temp = nums[a];
                nums[a] = nums[b];
                nums[b] = temp;
            }
        }
    }
}
