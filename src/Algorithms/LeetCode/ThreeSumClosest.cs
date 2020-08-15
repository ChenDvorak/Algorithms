using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class ThreeSumClosest
    {
        public int Run(int[] nums, int target)
        {
            Array.Sort(nums);
            int answer = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(target - sum) < Math.Abs(target - answer))
                        answer = sum;
                    if (sum > target)
                        right--;
                    else if (sum < target)
                        left++;
                    else
                        return sum;
                }
            }
            return answer;
        }
    }
}
