/*
 * divide two integers
 * given two integers dividend and divisor
 * divide two integers without using multiplication, division and mod operator
 * return the quotient after dividing dividend by divisor
 * the integer division should truncate toward zero which means losing its fractional part
 * for example, truncate(8.345) = 8 and truncate(-2.754) = -2
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms.LeetCode
{
    public class DivideTwoIntegers
    {
        [ThreadStatic]
        private int sign = 1;
        public int Run(int dividend, int divisor)
        {
            if (dividend == 0) return 0;
            if (divisor == 0) throw new DivideByZeroException();

            if (divisor == 1) return dividend;
            if (divisor == -1) return -dividend;

            if ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0))
                sign = -1;

            int a = dividend > 0 ? -dividend : dividend;
            int b = divisor > 0 ? -divisor : divisor;

            int quotient = Divide(a, b);
            return sign == -1 ? -quotient : quotient;
        }

        private int Divide(int dividend, int divisor)
        {
            if (dividend > divisor) return 0;
            int minimumQuotient = 1;
            int sum = divisor;

            while (sum + sum >= dividend)
            {
                minimumQuotient += minimumQuotient;
                sum += sum;
            }
            return minimumQuotient + Divide(dividend - sum, divisor);
        }
    }
}
