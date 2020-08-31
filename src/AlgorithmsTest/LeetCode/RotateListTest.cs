using Algorithms.BreadthFilstSearch;
using Algorithms.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class RotateListTest
    {
        [TestMethod]
        public void TestRotateList()
        {
            RotateList.ListNode head = new RotateList.ListNode(1);
            RotateList.ListNode node2 = new RotateList.ListNode(2);
            RotateList.ListNode node3 = new RotateList.ListNode(3);
            RotateList.ListNode node4 = new RotateList.ListNode(4);
            RotateList.ListNode node5 = new RotateList.ListNode(5);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var f = new RotateList();
            var answer = f.Run(head, 2);

            Console.WriteLine(answer.ToString());
        }
    }
}