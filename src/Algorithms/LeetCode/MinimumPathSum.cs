/*
 *  
 */
using System;

namespace Algorithms.LeetCode
{
    public class MinimumPathSum
    {
        public int Run(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (i == 0 && j == 0)
                        continue;
                    if (i == 0)
                        grid[i][j] += grid[i][j - 1];
                    else if (j == 0)
                        grid[i][j] += grid[i - 1][j];
                    else
                        grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                }
            }
            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
