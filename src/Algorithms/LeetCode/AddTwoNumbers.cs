using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// 两数相加
    /// </summary>
    public class AddTwoNumbers
    {
        public LinkedList<int> Run(LinkedList<int> l1, LinkedList<int> l2)
        {
            LinkedList<int> dummyHead = new LinkedList<int>();
            var p = l1.First; var q = l2.First;
            int carry = 0;
            while (p != null || q != null)
            {
                int sum = (p?.Value ?? 0) + (q?.Value ?? 0) + carry;
                carry = sum / 10;
                dummyHead.AddLast(sum % 10);
                p = p.Next;
                q = q.Next;
            }
            if (carry > 0)
                dummyHead.AddLast(carry);
            return dummyHead;
        }
    }
}
