/*
    Palindrome number
    determine whether an integer is a palindrome.
    an integer is a palindrome when it read the same backward as forward.
 */

using System;

namespace Algorithms.LeetCode
{
    public class PalindromeNumber
    {
        public bool Run(int value)
        {
            if (value < 0 || (value != 0 && value % 10 != 0))
                return false;
            int palindromeNumber = 0;
            while (palindromeNumber < value)
            {
                palindromeNumber * 10 + value % 10;
                value /= 10;
            }
            return palindromeNumber == value || palindromeNumber / 10 == value;
        }
    }
}