/*
 * rotate list
 * 
 * 
 *  public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x }; 
    }
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{

    public class RotateList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public override string ToString()
            {
                var v = this;
                StringBuilder s = new StringBuilder("[");
                while (v != null)
                {
                    s.Append($"{v.val}>");
                    v = v.next;
                }

                s.Append("null").Append(']');
                return s.ToString();
            }
        }


        public ListNode Run(ListNode head, int k)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode oldTail = head;

            int n = 1;
            for (; oldTail.next != null; n++)
            {
                oldTail = oldTail.next;
            }
            oldTail.next = head;

            var newTail = head;
            for (int i = 0; i < n - (k % n) - 1; i++)
            {
                newTail = newTail.next;
            }
            ListNode newHead = newTail.next;
            newTail.next = null;
            return newHead;
        }
    }
}
