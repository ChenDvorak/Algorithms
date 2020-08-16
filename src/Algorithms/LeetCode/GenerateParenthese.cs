/*
 *  Generate Parenthese
 *  Given n pairs of parenthese
 *  write a function to generate all combinations of well-formed parenthese
 */
using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public class GenerateParenthese
    {
        private List<string> answers;
        public List<string> Run(int n)
        {
            if (n < 1) return new List<string>();
            answers = new List<string>(n * n - 1);

            Dfs("", n, n);
            return answers;
        }

        private void Dfs(string current, int left, int right)
        { 
            if (left == 0 && right == 0)
            {
                answers.Add(current);
                return;
            }

            if (left > right)
                return;

            if (left > 0)
                Dfs(current + "(", left - 1, right);
            if (right > 0)
                Dfs(current + ")", left, right - 1);
        }
    }
}
