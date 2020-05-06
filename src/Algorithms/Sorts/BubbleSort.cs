/*
 *  冒泡排序
 *  
 *  算法：
 *      1、从第一个数开始遍历，每个数都逐个比较
 *      
 *  说明：
 *      冒泡排序唯一的用处就是用来对比其他排序是多么优秀，所以是算法书的常客
 */

namespace Algorithms.Sorts
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="value">待排序的数组</param>
        /// <returns>排序后的数组</returns>
        public int[] Sort(int[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1 - i; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        int temp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = temp;
                    }
                }
            }
            return value;
        }
    }
}
