using Algorithms.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace AlgorithmsTest.LeetCode
{
    /// <summary>
    /// 测试深度优先搜索
    /// </summary>
    [TestClass]
    public class AddToNumbersTest
    {
        /// <summary>
        /// 测试使用深度优先搜索走迷宫
        /// </summary>
        [TestMethod]
        public void Test()
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(2);
            l1.AddLast(9);
            l1.AddLast(8);

            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddLast(3);
            l2.AddLast(4);
            l2.AddLast(1);


            var a = new AddTwoNumbers();
            var result = a.Run(l1, l2);

            var arr = result.ToArray();

            var trueArr = new int[] { 5, 3, 0, 1 };
            Assert.IsTrue(arr.SequenceEqual(trueArr));
        }
    }
}
