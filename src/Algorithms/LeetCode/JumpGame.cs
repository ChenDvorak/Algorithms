/*
 *  given a array of non-negative integers
 *  you are initail positioned at the first index of array
 *  each element in the array represents your maximum jump length at that position
 *  determine if you are able to reach the last index
 */
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Algorithms.LeetCode
{
    public class JumpGame
    {
        private Dictionary<int, bool> flags;
        public bool Run(int[] nums)
        {
            flags = new Dictionary<int, bool>(nums.Length);

            return Dfs(nums, 0);
        }

        private bool Dfs(int[] nums, int index)
        {
            if (index == nums.Length - 1)
                return true;
            if (nums[index] == 0 || index > nums.Length - 1)
                return false;
            if (flags.ContainsKey(index))
                return flags[index];

            for (int i = 1; i <= nums[index]; i++)
            {
                if (Dfs(nums, index + i))
                    return true;
                flags[i] = false;
            }
            return false;
        }
    }
}
