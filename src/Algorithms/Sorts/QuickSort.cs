/*
 *  快速排序
 *  将数组从小到大排序后返回
 *  
 *  算法：
 *      1、从数组中选择一个数作为基准值，
 *      2、然后选择数组头部坐标为左标，数组尾部坐标为右标，
 *      3、将右标作为起点，从右往左遍历，直到右标的值小于基准值或者右标与左标相等，
 *      4、将左标作为起点，从左往右遍历，直到左标的值大于基准值或者左标与右标相等，
 *      5、此时如果左标不等于右标，则交换左标和右标的值，如果相等，则交换左标和基准数的值（此时左标和右标相等），此时基准数左边的值全部小于基准数，基准数右边的值全部大于基准数，
 *      6、将基准数左边的数组从步骤 1 开始执行算法，若数组只有一个以下的数，则不需要执行，
 *      7、将基准数右边的数组从步骤 1 开始执行算法，若数组只有一个以下的数，则不需要执行。
 *  
 *  说明：
 *      快速排序使用了分治法的思想，将一个大问题分解成多个相等的小问题，逐一解决，
 *      快速排序选择了一个数作为基准值，将所有比基准值小的值放在基准值的左边，所有比基准值大的值放在右边，
 *      再从基准值左侧和右侧中各自选取新的基准值进行排序，直到排序完成。
 *      在理想情况下，如果基准值选取到的是数组的中间数，那么快速排序能达到 O(nlogn) 的时间复杂度，
 *      但如果基准值选取到的刚好是最大数或最小数，那么时间复杂度会将为 O(n2)。
 */

namespace Algorithms.Sorts
{
    public class QuickSort
    {
        /// <summary>
        /// 将数组从小到大排序后返回
        /// </summary>
        /// <param name="value">待排序的数组</param>
        /// <returns>排序后的数组</returns>
        public int[] Sort(int[] value)
        {
            _quickSort(ref value, 0, value.Length - 1);
            return value;
        }

        private void _quickSort(ref int[] value, int startIndex, int rightIndex)
        {
            //  leftIndex:  左标
            //  rightIndex: 右标

            if (value.Length <= 1 || startIndex == rightIndex)
                return;

            int FLAG_INDEX = startIndex;
            int flag = value[FLAG_INDEX];
            int leftIndex = startIndex;

            while (leftIndex != rightIndex)
            {
                while (leftIndex != rightIndex && value[rightIndex] >= flag)
                {
                    --rightIndex;
                }
                while (leftIndex != rightIndex && value[leftIndex] <= flag)
                {
                    ++leftIndex;
                }

                if (value[leftIndex] == value[rightIndex])
                    continue;

                int t = value[leftIndex];
                value[leftIndex] = value[rightIndex];
                value[rightIndex] = t;
            }
            if (value[leftIndex] != flag)
            {
                value[FLAG_INDEX] = value[leftIndex];
                value[leftIndex] = flag;
            }

            if (leftIndex - 1 >= startIndex)
                _quickSort(ref value, startIndex, leftIndex - 1);
            if (leftIndex + 1 < value.Length)
                _quickSort(ref value, leftIndex + 1, value.Length - 1);
        }
    }
}
