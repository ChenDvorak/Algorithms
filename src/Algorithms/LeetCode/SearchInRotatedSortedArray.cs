using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class SearchInRotatedSortedArray
    {
        public const int NOT_FOUND = -1;
        public int Run(int[] nums, int target)
        {
            int mid, left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                mid = (left + right) >> 1;
                if (target == nums[mid]) return mid;

                if (nums[left] <= nums[mid])
                {
                    if (target >= nums[left] && target < nums[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else
                {
                    if (target > nums[mid] && target <= nums[right])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                //  另一种写法
                /*

                if ((nums[left] < nums[mid]) ^ (target > nums[mid]) ^ (nums[left] > target))
                    left = mid + 1;
                else
                    right = mid - 1;
                
                 */
            }
            return NOT_FOUND;
        }
    }
}
