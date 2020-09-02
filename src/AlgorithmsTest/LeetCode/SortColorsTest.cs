using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SortColorsTest
    {
        [TestMethod]
        public void TestSortColors()
        {
            var f = new Algorithms.LeetCode.SortColors();
            var answer = f.Run(new int[] { 2, 0, 2, 1, 1, 0 });
            Assert.IsTrue(answer.SequenceEqual(new int[] { 0, 0, 1, 1, 2, 2 }));
        }
    }
}