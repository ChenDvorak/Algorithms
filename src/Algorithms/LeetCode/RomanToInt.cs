using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class RomanToInt
    {
        public int Run(string roman)
        {
            int sum = 0;
            int preNum = GetValue(roman[0]);

            for (int i = 1; i < roman.Length; i++)
            {
                int num = GetValue(roman[i]);
                if (preNum < num)
                    sum -= preNum;
                else
                    sum += preNum;
                preNum = num;
            }
            sum += preNum;
            return sum;
        }

        private int GetValue(char roman) => roman switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}
