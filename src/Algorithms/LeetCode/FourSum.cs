using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class FourSum
    {
        public List<List<int>> Run(int[] nums, int target)
        {
            List<List<int>> answers = new List<List<int>>();
            if (nums == null || nums.Length < 4) return answers;
            int len = nums.Length;
            Array.Sort(nums);

            for (int a = 0; a < len - 3; a++)
            {
                for (int b = a + 1; b < len - 2; b++)
                {
                    if (b > a + 1 && nums[b] == nums[b - 1]) continue;
                    int left = b + 1, right = len - 1;
                    while (left < right)
                    {
                        int sum = nums[a] + nums[b] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            answers.Add(new List<int>(new int[] { nums[a], nums[b], nums[left], nums[right] }));
                            while (left < right && nums[left] == nums[left + 1])
                                left++;
                            while (left < right && nums[right] == nums[right - 1])
                                right--;
                            left++;
                            right--;
                        }
                        else if (sum < target)
                            left++;
                        else
                            right--;
                    }
                }
            }
            return answers;
        }
    }
}
