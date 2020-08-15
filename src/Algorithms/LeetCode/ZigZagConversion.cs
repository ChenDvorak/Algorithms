/*
 * ZigZag Conversion
 * The string "PAYPALISHIRING" in written in a zigzag pattern on a given number of row like this:
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * And then read line by line: "PAHNAPLSIIGYIR"
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class ZigZagConversion
    {
        public string Run(string s, int row)
        {
            if (row < 2) return s;

            StringBuilder[] rows = new StringBuilder[row];
            for (int j = 0; j < rows.LongLength; j++)
            {
                rows[j] = new StringBuilder();
            }

            int i = 0, flag = -1;
            foreach (char c in s)
            {
                rows[i].Append(c);
                if (i == 0 || i == row - 1)
                    flag = -flag;
                i += flag;
            }
            StringBuilder answer = new StringBuilder(s.Length);
            foreach (var rowStr in rows)
            {
                answer.Append(rowStr);
            }
            return answer.ToString();
        }
    }
}
