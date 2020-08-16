/*
 *  两数之和
 *  
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class TowSum
    {
        public int[] Run(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                 int complement  = target - nums[i];
                if (map.ContainsKey(complement))
                    return new int[] { map[i], i };
            }
            throw new ArgumentException();
        }
    }
}
