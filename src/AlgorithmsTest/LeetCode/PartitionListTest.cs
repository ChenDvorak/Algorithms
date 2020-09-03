using Algorithms.BreadthFilstSearch;
using Algorithms.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class PartitionListTest
    {
        [TestMethod]
        public void TestPartitionList()
        {
            PartitionList.ListNode head = new PartitionList.ListNode(1);
            PartitionList.ListNode node2 = new PartitionList.ListNode(4);
            PartitionList.ListNode node3 = new PartitionList.ListNode(3);
            PartitionList.ListNode node4 = new PartitionList.ListNode(2);
            PartitionList.ListNode node5 = new PartitionList.ListNode(5);
            PartitionList.ListNode node6 = new PartitionList.ListNode(6);
            head.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;

            var f = new PartitionList();
            var answer = f.Run(head, 3);
            while (answer != null)
            {
                Console.Write($" {answer.Val} ->");
                answer = answer.Next;
            }
        }
    }
}