/*
 * letter combinations of phone number
 * given a string containing digits from 2-9 inclusive.
 * return all possible letter combinations that the number could represent.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class LetterCombinationsOfPhoneNumber
    {
        private readonly string[] phone = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        private readonly List<string> answers = new List<string>(6);

        public List<string> Run(string digits)
        {
            if (!string.IsNullOrWhiteSpace(digits))
                FindCombinations(digits, 0, null);
            return answers;
        }

        private void FindCombinations(string digits, int index, StringBuilder s)
        {
            if (s == null) s = new StringBuilder(5);
            if (index == digits.Length)
            {
                answers.Add(s.ToString());
                return;
            }
            char c = digits[index];
            string letters = phone[c - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                FindCombinations(digits, index + 1, s.Append(letters[i]));
                s.Remove(s.Length - 1, 1);
            }
        }
    }
}
