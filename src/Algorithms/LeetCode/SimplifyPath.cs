/*
 *  simplify path
 *  given an absolute path for a file (Unix-style), simplify it.
 *  or in other words, convert it to the canonical path.
 */
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.LeetCode
{
    public class SimplifyPath
    {

        public string Run(string path)
        {
            var paths = path.Split('/');
            Stack<string> s = new Stack<string>(paths.Length);

            foreach (var p in paths)
            {
                if (p == "..")
                {
                    if (s.Count > 0)
                        s.Pop();
                }
                else if (!string.IsNullOrWhiteSpace(p) && p != ".")
                    s.Push(p);
            }
            return $"/{string.Join('/', s.ToArray().Reverse())}";
        }
    }
}
