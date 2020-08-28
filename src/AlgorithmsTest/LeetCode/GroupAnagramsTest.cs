using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class GroupAnagramsTest
    {
        [TestMethod]
        public void TestGroupAnagrams()
        {
            var f = new Algorithms.LeetCode.GroupAnagrams();
            var answers = f.Run(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            foreach (var item in answers)
            {
                foreach (var v in item)
                {
                    Console.Write($"{v} ");
                }
                Console.WriteLine();
            }
        }
    }
}