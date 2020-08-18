/*
 *  find first and last position of element in sorted array
 *  given an array of integers nums sorted in ascending order
 *  find the starting and ending position of a given target value
 *  your algorithm's runtime complexity must be in order of O(log n)
 *  if the target is not found an array, return [-1, -1]
 */

namespace Algorithms.LeetCode
{
    public class FindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] Run(int[] nums, int target)
        {
            int firstIndex = FindIndex(nums, target, true);
            if (nums[firstIndex] != target) return new int[] { -1, -1 };
            int lastIndex = FindIndex(nums, target, false);
            return new int[] { firstIndex, lastIndex };
        }

        private int FindIndex(int[] nums, int target, bool findLeft)
        {
            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                int mid = (left + right) >> 1;
                if (nums[mid] > target || (findLeft && nums[mid] == target))
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }
    }
}
