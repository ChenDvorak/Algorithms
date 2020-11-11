using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Algorithms.Heap
{
    /// <summary>
    /// There is a minimum heap
    /// </summary>
    public class MinimunHeap<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public bool IsEmpty => data.Count() != 0;
        private readonly List<T> data;

        public MinimunHeap()
        {
            data = new List<T>();
        }

        public void Push(T item)
        {
            data.Add(item);

            int last = data.Count() - 1;
            int parent = ParentIndex(last);
            while (parent >= 0)
            {
                if (data[parent].CompareTo(item) > 0)
                {
                    T t = data[parent];
                    data[parent] = item;
                    data[last] = t;
                }
                last = parent;
                parent = ParentIndex(parent);
            }
        }

        public T Pop()
        {
            int n = data.Count - 1;
            if (n <= 0)
            {
                var r = data.FirstOrDefault();
                data.Clear();
                return r;
            }

            var result = data.First();
            data[0] = data[n - 1];
            data.RemoveAt(n - 1);

            int parent = 0;
            int child = LeftChildIndex(parent);

            while (child < n)
            {
                if (child < n - 1)
                    if (data[child].CompareTo(data[child + 1]) > 0)
                        child++;
                if (data[parent].CompareTo(data[child]) <= 0)
                    break;

                var t = data[parent];
                data[parent] = data[child];
                data[child] = t;

                parent = child;
                child = LeftChildIndex(parent);
            }

            return result;
        }

        [Pure]
        private int ParentIndex(int index)
        {
            return (index - 1) >> 1;
        }

        [Pure]
        private int LeftChildIndex(int index)
        {
            return (index << 1) + 1;
        }

        [Pure]
        private int RightChildIndex(int index)
        {
            return (index << 1) + 2;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
