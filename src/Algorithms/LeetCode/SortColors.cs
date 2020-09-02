/*
 *  sort colors
 *  
 *  given an narray with n objects colored red, white or blue
 *  sort them in-place so that object of the same color are adjacent with the colors in the order red, white and blue.
 *  here, we will use the integers 0, 1 and 2 to represent the color red, white and blue respectively.
 */

namespace Algorithms.LeetCode
{
    public class SortColors
    {
        const int RED = 0;
        const int BLUE = 2;

        public int[] Run(int[] nums)
        {
            int left = 0,
                right = nums.Length - 1,
                current = 0;

            int temp;
            while (current < right)
            {
                if (nums[current] == RED)
                {
                    temp = nums[current];
                    nums[current++] = nums[left];
                    nums[left++] = temp;
                }
                else if (nums[current] == BLUE)
                {
                    temp = nums[current];
                    nums[current] = nums[right];
                    nums[right--] = temp;
                }
                else
                    current++;
            }
            return nums;
        }
    }
}
