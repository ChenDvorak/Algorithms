/*
 *  unique path 2
 *  a robot is located at the top-left corner of a m * n grid (marked "Start" in the diagram below).
 *  the robot can only move either down or right at any point in time.
 *  the robot is try to reach the bottom-right corner of the grid (markd "Finish" in the diagram below).
 *  now consider if some obstacles are added to the grids, how many unique paths would there be?
 *  an obstacle and empty space is marked as 1 and 0 respectively in the grid.
 */

namespace Algorithms.LeetCode
{
    public class UniquePaths2
    {
        public int Run(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length,
                n = obstacleGrid[0].Length;
            int[] f = new int[n];

            f[0] = obstacleGrid[0][0] == 0 ? 1 : 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        f[j] = 0;
                        continue;
                    }
                    if (j > 0 && obstacleGrid[i][j - 1] == 0)
                    {
                        f[j] = f[j - 1];
                    }
                }
            }
            return f[n - 1];
        }
    }
}
