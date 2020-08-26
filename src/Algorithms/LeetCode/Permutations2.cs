/*
 *  permutations 2
 *  given a collection of numbers that might contain duplicates
 *  return all possible unique permutations
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// 全排列 2
    /// </summary>
    public class Permutations2
    {
        private readonly List<List<int>> answers = new List<List<int>>();

        public List<List<int>> Run(int[] nums)
        {

            if (nums.Length == 1)
                answers.Add(nums.ToList());
            Array.Sort(nums);
            Dfs(nums, 0, new Stack<int>(nums.Length), new bool[nums.Length]);
            return answers;
        }

        private void Dfs(int[] nums, int depth, Stack<int> path, bool[] flag)
        {
            if (depth == nums.Length)
            {
                answers.Add(path.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (flag[i]) continue;
                if (i > 0 && nums[i] == nums[i - 1] && !flag[i - 1])
                    continue;

                path.Push(nums[i]);
                flag[i] = true;
                Dfs(nums, depth + 1, path, flag);

                flag[i] = false;
                path.Pop();
            }
        }
    }
}
