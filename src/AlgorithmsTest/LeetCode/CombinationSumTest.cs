using Algorithms.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest.LeetCode
{
    /// <summary>
    /// 测试深度优先搜索
    /// </summary>
    [TestClass]
    public class CombinationSumTest
    {
        /// <summary>
        /// 测试使用深度优先搜索走迷宫
        /// </summary>
        [TestMethod]
        public void TestCombinationSum()
        {
            var f = new CombinationSum();

            var answers = f.Run(new int[] { 2, 3, 6, 7 }, 7);
            answers = f.Run(new int[] { 2, 3, 5 }, 8);
        }
    }
}
