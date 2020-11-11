using System;
using Xunit;

namespace Test
{
    public class MinimunHeap
    {
        [Fact]
        public void Test1()
        {
            //  arrange
            int[] data = new int[] { 2, 3, 1, 5 };
            Algorithms.Heap.MinimunHeap<int> heap = 
                new Algorithms.Heap.MinimunHeap<int>();
            const int EXPECTED_RESULT = 1;

            //  act
            foreach (var item in data)
            {
                heap.Push(item);
            }

            //  assert
            var result = heap.Pop();
            Assert.Equal(EXPECTED_RESULT, result);
        }

        [Fact]
        public void Test2()
        {
            //  arrange
            int[] data = new int[] { 2, 3, 1, 5 };
            Algorithms.Heap.MinimunHeap<int> heap =
                new Algorithms.Heap.MinimunHeap<int>();
            const int EXPECTED_RESULT = 2;

            //  act
            foreach (var item in data)
            {
                heap.Push(item);
            }

            //  assert
            var result = heap.Pop();
            result = heap.Pop();
            Assert.Equal(EXPECTED_RESULT, result);
        }
    }
}
