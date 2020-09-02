/*
 *  write an efficient algorithm that searches for a value in an m * n matrix.
 *  this matrix has the following properties.
 *      - integers in each row are sorted from left to right.
 *      - the first integer of each row is greater than the last integer of the previous row.
 */

namespace Algorithms.LeetCode
{
    public class SearchA2DMatrix
    {
        public bool Run(int[][] matrix, int target)
        {
            int m = matrix.Length,
                n = matrix[0].Length;

            if (target < matrix[0][0] || target > matrix[m - 1][n - 1])
                return false;

            int left = 0, right = m * n - 1;
            int mid, element;

            while (left <= right)
            {
                mid = (left + right) >> 1;
                element = matrix[mid / n][mid % n];
                if (element == target) return true;
                else
                {
                    if (target < element)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
            }
            return false;
        }
    }
}
