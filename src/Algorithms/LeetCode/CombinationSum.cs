using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    public class CombinationSum
    {

        public List<List<int>> Run(int[] nums, int target)
        {
            Array.Sort(nums);
            if (nums.Contains(0))
                throw new ArgumentException("not allow zero");

            List<List<int>> answers = new List<List<int>>(nums.Length);
            Dfs(nums, target, 0, answers, new Stack<int>(nums.Length));
            return answers;
        }

        private void Dfs(int[] nums, int residue, int begin, List<List<int>> answers, Stack<int> path)
        {
            if (residue == 0)
            {
                answers.Add(path.ToList());
                return;
            }

            for (int i = begin; i < nums.Length; i++)
            {
                if (nums[i] > residue)
                    break;

                path.Push(nums[i]);
                Dfs(nums, residue - nums[i], i, answers, path);
                path.Pop();
            }
        }
    }
}
