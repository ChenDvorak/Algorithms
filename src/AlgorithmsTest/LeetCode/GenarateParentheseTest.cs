using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class GenarateParentheseTest
    {
        [TestMethod]
        public void TestGenarateParenthese()
        {
            var f = new Algorithms.LeetCode.GenerateParenthese();
            var answers = f.Run(3);
            foreach (var item in answers)
            {
                Console.Write($" {item} ");
            }
        }
    }
}