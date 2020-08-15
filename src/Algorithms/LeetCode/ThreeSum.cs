using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class ThreeSum
    {
        public List<List<int>> Run(int[] nums)
        {
            List<List<int>> answer = new List<List<int>>();

            if (nums == null || nums.Length < 3) return answer;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) return answer;
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        answer.Add(new List<int>(new int[] { nums[i], nums[left], nums[right] }));
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                        left++;
                    else
                        right--;
                }
            }
            return answer;
        }
    }
}
