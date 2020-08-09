/*
    Reverse integer
    Given a 32-bit signed integer, reverse digits of an integer.
 */
using System;
namespace Algorithms.LeetCode
{
    public class ReverseInteger
    {
        public int Run(int value)
        {
            const int TOP_VALUE = int.MaxValue / 10 - 7;
            const int DOWN_VALUE = int.MinValue + 8;

            int answer = 0;
            int temp = 0;

            while (value != 0)
            {
                //  取个位数
                temp = value % 10;
                value /= 10;
                Console.WriteLine($"value = {value}");
                if (answer >= TOP_VALUE || answer <= DOWN_VALUE)
                    return 0;
                answer *= 10;
                answer += temp;
                Console.WriteLine($"answer: {answer}");
            }
            return answer;
        }
    }
}