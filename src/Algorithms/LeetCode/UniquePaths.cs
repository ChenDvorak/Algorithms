/*
 *  unique paths
 *  a robot is located at the top-left corner of a m * n grid (marked 'Satrt' in the diagram below).
 *  the robot can only either down or right at any point in time.
 *  the robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
 *  how many possible unique paths are there?   
 */

namespace Algorithms.LeetCode
{
    public class UniquePaths
    {
        public int Run(int m, int n)
        {
            int[,] map = new int[m, n];
            for (int i = 0; i < n; i++)
                map[0, i] = 1;
            for (int i = 0; i < m; i++)
                map[i, 0] = 1;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    map[i, j] = map[i - 1, j] + map[i, j - 1];
                }
            }
            return map[m - 1, n - 1];
        }
    }
}
