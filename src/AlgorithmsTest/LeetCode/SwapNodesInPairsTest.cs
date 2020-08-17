using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class SwapNodesInPairsTest
    {
        [TestMethod]
        public void TestSwapNodesInPairs()
        {
            var f = new Algorithms.LeetCode.SwapNodesInPairs();
            Algorithms.LeetCode.SwapNodesInPairs.ListNode head = new Algorithms.LeetCode.SwapNodesInPairs.ListNode(1);
            head.Next = new Algorithms.LeetCode.SwapNodesInPairs.ListNode(2);
            head.Next.Next = new Algorithms.LeetCode.SwapNodesInPairs.ListNode(3);
            head.Next.Next.Next = new Algorithms.LeetCode.SwapNodesInPairs.ListNode(4);

            Console.WriteLine("after swap");
            var temp = head;
            do
            {
                Console.Write($" {temp.Value} ");
                temp = temp.Next;
            } while (temp != null);

            head = f.Run(head);
            Console.WriteLine("\nbefore swap");
            temp = head;
            do
            {
                Console.Write($" {temp.Value} ");
                temp = temp.Next;
            } while (temp != null);
        }
    }
}