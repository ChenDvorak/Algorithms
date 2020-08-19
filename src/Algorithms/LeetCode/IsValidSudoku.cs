/*
 * valid sudoku
 * determine if a sudoku board is valid.
 * only the filled cells need to be validate according to the following rules
 *      1. each row must contain the digits 1-9 without repetition.
 *      2. each columns most contain the digits 1-9 without repetition.
 *      3. each of the 9 3*3 sub-box of the grid must contain the digits 1-9 without repetition
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class IsValidSudoku
    {
        private const char NOT_FILLED = '.';
        public bool Run(char[][] borad)
        {
            int[,] rows = new int[9, 9];
            int[,] columns = new int[9, 9];
            int[,] boxIndices = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (borad[i][j] == NOT_FILLED)
                        continue;

                    int index = borad[i][j] - '1';
                    int boxIndex = (i / 3) * 3 + j / 3;
                    if (rows[i, index] == 0 && columns[j, index] == 0 && boxIndices[boxIndex, index] == 0)
                    {
                        rows[i, index] = 1;
                        columns[j, index] = 1;
                        boxIndices[boxIndex, index] = 1;
                    }
                    else
                        return false;
                }
            }
            return true;
        }

        public bool OtherRun(char[][] borad)
        {
            int[] flags = new int[9];

            int rowValue, columnValue, boxValue;
            int boxIndex;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    rowValue = 0x01 << (borad[i][j] - '1');
                    columnValue = rowValue << 9;
                    boxValue = columnValue << 9;

                    boxIndex = (i / 3) * 3 + j / 3;

                    if ((flags[i] & rowValue) == 0 && (flags[j] & columnValue) == 0 & (flags[boxValue] & boxValue) == 0)
                    {
                        flags[i] = flags[i] | rowValue;
                        flags[j] = flags[j] | columnValue;
                        flags[boxIndex] = flags[boxIndex] | boxValue;
                    }
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
