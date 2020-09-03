using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public class SubsetsII
    {
        private int length;
        private List<List<int>> answers;
        private List<int> path;
        private int[] nums;
        public List<List<int>> Run(int[] nums)
        {
            this.nums = nums;
            length = nums.Length;
            answers = new List<List<int>>(length)
            {
                new List<int>()
            };
            path = new List<int>(length);

            Dfs(0);
            return answers;
        }

        private void Dfs(int index)
        {
            if (index == length) return;
            for (int i = index; i < length; i++)
            {
                if (i > index && nums[i] == nums[i - 1]) continue;
                path.Add(i);
                answers.Add(path);
                Dfs(index + 1);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
