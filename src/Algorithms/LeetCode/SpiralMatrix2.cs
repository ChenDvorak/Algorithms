/*
 *  spiral matrix 2
 *  given a positive integer n, generate a square matrix filled with elements from 1 to n^2 in spiral order
 */

namespace Algorithms.LeetCode
{
    public class SpiralMatrix2
    {
        public int[,] Run(int n)
        {
            int number = 0;
            var matrix = new int[n, n];
            int u = 0, d = n - 1;
            int l = u, r = d;
            int target = n * n;
            while (number < target)
            {
                for (int i = l; i <= r; i++)
                    matrix[u, i] = ++number;
                ++u;

                for (int i = u; i <= d; i++)
                    matrix[i, r] = ++number;
                --r;

                for (int i = r; i >= l; i--)
                    matrix[d, i] = ++number;
                --d;

                for (int i = d; i >= u; i--)
                    matrix[i, l] = ++number;
                ++l;
            }
            return matrix;
        }
    }
}
