/*
 *  spiral matrix
 */

using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public class SpiralMatrix
    {
        public int[] Run(int[][] nums)
        {
            int uBound = 0;
            int bBound = nums.Length - 1;
            int lBound = 0;
            int rBound = nums[0].Length - 1;

            List<int> answer = new List<int>(bBound * rBound);

            while (true)
            {
                for (int i = lBound; i <= rBound; i++)
                    answer.Add(nums[uBound][i]);
                if (++uBound > bBound) break;
                for (int i = uBound; i <= bBound; i++)
                    answer.Add(nums[i][rBound]);
                if (--rBound < lBound) break;
                for (int i = rBound; i >= lBound; i--)
                    answer.Add(nums[bBound][i]);
                if (--bBound < uBound) break;
                for (int i = bBound; i >= uBound; i--)
                    answer.Add(nums[i][lBound]);
                if (++lBound > rBound) break;
            }
            return answer.ToArray();
        }
    }
}
