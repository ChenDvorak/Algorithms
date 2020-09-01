using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class SetMatrixZeros
    {
        public void Run(int[][] matrix)
        {
            bool flag = false;
            int row = matrix.Length;
            int column = matrix[0].Length;

            for (int i = 0; i < column; i++)
            {
                if (matrix[0][i] == 0) flag = true;
                for (int j = 0; j < row; j++)
                {
                    if (matrix[i][j] == 0)
                        matrix[i][0] = matrix[0][j] = 0;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                        matrix[i][j] = 0;
                }
                if (flag) matrix[i][0] = 0;
            }
        }
    }
}
