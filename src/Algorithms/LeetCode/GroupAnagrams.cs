/*
 *  group anagrams
 *  given an array strings, group anagrams together
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class GroupAnagrams
    {
        public List<List<string>> Run(string[] strs)
        {
            if (strs.Length == 0)
                return new List<List<string>>();

            Dictionary<string, List<string>> answers = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                int[] flag = new int[26];

                foreach (var c in str)
                {
                    flag[c - 'a'] += 1;
                }
                string key = string.Join(',', flag);

                if (!answers.ContainsKey(key))
                    answers.Add(key, new List<string>());
                answers[key].Add(str);
            }
            return new List<List<string>>(answers.Values);
        }
    }
}
