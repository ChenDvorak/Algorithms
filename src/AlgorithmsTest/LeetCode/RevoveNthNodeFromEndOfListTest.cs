using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsTest.LeetCode
{
    [TestClass]
    public class RevoveNthNodeFromEndOfListTest
    {
        [TestMethod]
        public void TestRevoveNthNodeFromEndOfList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);

            Console.WriteLine("before remove");
            var h = list.First;
            while (h != null)
            {
                Console.Write(h.Value);
                h = h.Next;
            }

            var f = new Algorithms.LeetCode.RemoveNthNodeFromEndOfList();
            h = f.Run(list, 2);

            Console.WriteLine("\nafter remove");
            while (h != null)
            {
                Console.Write(h.Value);
                h = h.Next;
            }
        }
    }
}