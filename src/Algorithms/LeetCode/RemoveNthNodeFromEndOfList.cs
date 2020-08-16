/*
 * given a linked list.
 * remove the n-th node from the end of list and return its head
 */

using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public class RemoveNthNodeFromEndOfList
    {
        public LinkedListNode<int> Run(LinkedList<int> list, int n)
        {
            //  L - n + 1

            var head = list.First;
            list.AddBefore(head, 0);
            LinkedListNode<int> dummy = list.First;

            LinkedListNode<int> first = dummy, second = dummy;
            for (int i = 0; i < n + 1; i++)
                first = first.Next;
            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }
            list.Remove(second.Next);
            return dummy.Next;
        }
    }
}
