/*
 *  you are given an n * n 2D matrix representing an image.
 *  rotate the image by 90 degrees (clockwise)
 */

namespace Algorithms.LeetCode
{
    /// <summary>
    /// 旋转图像
    /// </summary>
    public class RotateImage
    {
        public int[][] Run(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < (n >> 1); i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][n - 1 - i];
                    matrix[j][n - 1 - i] = temp;

                    temp = matrix[i][j];
                    matrix[i][j] = matrix[n - 1 - i][n - 1 - j];
                    matrix[n - 1 - i][n - 1 - j] = temp;

                    temp = matrix[i][j];
                    matrix[i][j] = matrix[n - 1 - j][i];
                    matrix[n - 1 - j][i] = temp;
                }
            }
            return matrix;
        }
    }
}
