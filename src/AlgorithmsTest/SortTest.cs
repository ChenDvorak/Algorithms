using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorts;

namespace AlgorithmsTest
{
    /// <summary>
    /// ≈≈–Ú≤‚ ‘
    /// </summary>
    [TestClass]
    public class SortTest
    {
        /// <summary>
        /// ≤‚ ‘√∞≈›≈≈–Ú
        /// </summary>
        [TestMethod]
        public void TestBubbleSort()
        {
            int[] value = { 2, 332, 19, 4, 091, -32 };
            int[] afterSort = { -32, 2, 4, 19, 091, 332 };

            BubbleSort bubbleSort = new BubbleSort();
            var sortedValue = bubbleSort.Sort(value);

            for (int i = 0; i < sortedValue.Length; i++)
            {
                if (sortedValue[i] != afterSort[i])
                    Assert.Fail("≈≈–Ú ß∞‹");
            }
        }

        /// <summary>
        /// ≤‚ ‘øÏÀŸ≈≈–Ú
        /// </summary>
        [TestMethod]
        public void TestQuickSort()
        {
            int[] value = { 2, 332, 19, 4, 091, -32 };
            int[] afterSort = { -32, 2, 4, 19, 091, 332 };

            QuickSort quickSort = new QuickSort();
            var sortedValue = quickSort.Sort(value);

            for (int i = 0; i < sortedValue.Length; i++)
            {
                if (sortedValue[i] != afterSort[i])
                    Assert.Fail("≈≈–Ú ß∞‹");
            }
        }
    }
}
