/*
 *  combinations
 *  given two integers n and k.
 *  return possible combinations of k numbers out of 1...n
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    public class Combinations
    {
        const int START_NUMBER = 1;
        private List<List<int>> answers;
        public List<List<int>> Run(int n, int k)
        {
            answers = new List<List<int>>();

            Backtrack(START_NUMBER, new Stack<int>(k), n, k);
            return answers;
        }
        
        private void Backtrack(int startIndex, Stack<int> path, int n, int k)
        {
            if (path.Count == k)
            {
                var p = path.ToList();
                p.Reverse();
                answers.Add(p);
                return;
            }
            for (int i = startIndex; i <= n; i++)
            {
                path.Push(i);
                Backtrack(i + 1, path, n, k);
                path.Pop();
            }
        }
    }
}
