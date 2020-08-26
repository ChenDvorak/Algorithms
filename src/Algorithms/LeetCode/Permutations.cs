using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// 全排列
    /// </summary>
    public class Permutations
    {
        private readonly List<List<int>> answers = new List<List<int>>();
        public List<List<int>> Run(int[] nums)
        {
            if (nums.Length == 1)
                answers.Add(nums.ToList());

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

                path.Push(nums[i]);
                flag[i] = true;
                Dfs(nums, depth + 1, path, flag);

                flag[i] = false;
                path.Pop();
            }
        }
    }
}
