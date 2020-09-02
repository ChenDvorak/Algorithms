/*
 *  subsets
 *  given a set of distince integers nums.
 *  return all possible subsets (the power set).
 *  the solution set must not contain duplicate subsets.
 */
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.LeetCode
{
    public class Subsets
    {
        List<List<int>> answers = new List<List<int>>();
        public List<List<int>> Run(int[] nums)
        {
            Backtrack(0, new Stack<int>(nums.Length), nums);
            return answers;
        }

        private void Backtrack(int index, Stack<int> path, int[] nums)
        {
            answers.Add(path.ToList());
            for (int i = index; i < nums.Length; i++)
            {
                path.Push(nums[i]);
                Backtrack(i + 1, path, nums);
                path.Pop();
            }
        }
    }
}
