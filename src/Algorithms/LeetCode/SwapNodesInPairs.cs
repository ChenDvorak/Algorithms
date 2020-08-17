/*
 * swap nodes in pairs
 * given a linked list
 * swap every two adjacent nodes and return its head
 * you may not modify the values in the list's node
 * only nodes itseft may be changed.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class SwapNodesInPairs
    {
        public class ListNode
        {
            public int Value;
            public ListNode Next;
            public ListNode(int x) { Value = x; }
        }

        public ListNode Run(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.Next = head;
            var temp = dummy;
            while (temp.Next != null && temp.Next.Next != null)
            {
                ListNode left = temp.Next;
                var right = left.Next;
                temp.Next = right;
                left.Next = right.Next;
                right.Next = left;

                temp = left;
            }
            return dummy.Next;
        }
    }
}
