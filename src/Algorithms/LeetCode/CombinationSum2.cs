using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    public class CombinationSum2
    {
        public List<List<int>> Run(int[] nums, int target)
        {
            Array.Sort(nums);
            if (nums.Contains(0)) throw new ArgumentNullException();

            List<List<int>> answers = new List<List<int>>(nums.Length);
            Dfs(nums, 0, target, new Stack<int>(nums.Length), answers);
            return answers;
        }

        private void Dfs(int[] nums, int begin, int residue, Stack<int> path, List<List<int>> answers)
        {
            if (residue == 0)
            {
                answers.Add(path.ToList());
                return;
            }

            for (int i = begin; i < nums.Length; i++)
            {
                if (nums[i] > residue)
                    continue;

                path.Push(nums[i]);
                Dfs(nums, i + 1, residue - nums[i], path, answers);
                path.Pop();
            }
        }
    }
}
