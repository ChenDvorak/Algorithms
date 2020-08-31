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

        /// <summary>
        /// 深度优先搜索算法
        /// 时间 O(n)
        /// 空间 O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="index"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 贪心算法
        /// 时间 O(n)
        /// 空间 O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool Run2(int[] nums)
        {
            int n = nums.Length;
            int rightMost = 0;
            for (int i = 0; i < n; i++)
            {
                if (i > rightMost) 
                    return false;
                rightMost = Math.Max(rightMost, i + nums[i]);
                if (rightMost >= n - 1)
                    return true;
            }
            return false;
        }
    }
}
