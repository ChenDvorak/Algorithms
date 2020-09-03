/*
 *  partition list
 *  given a linxed list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
 *  you should preserve the original relative order of the nodes in each of the two partitions.
 */

namespace Algorithms.LeetCode
{
    public class PartitionList
    {
        public class ListNode
        {
            public int Val;
            public ListNode Next;
            public ListNode(int x) { Val = x; }
        }

        public ListNode Run(ListNode head, int x)
        {
            ListNode before = new ListNode(0),
                     after = new ListNode(0);
            ListNode beforeDummy = before,
                     afterDummy = after;

            while (head != null)
            {
                if (head.Val < x)
                {
                    before.Next = head;
                    before = before.Next;
                }
                else
                {
                    after.Next = head;
                    after = after.Next;
                }
                head = head.Next;
            }
            after.Next = null;
            before.Next = afterDummy.Next;
            return beforeDummy;
        }
    }
}
