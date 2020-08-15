using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class ContainerWithMostWater
    {
        public int Run(int[] height)
        {
            int i = 0, j = height.Length - 1, area = 0;
            while (i < j)
            {
                area = height[i] < height[j] ?
                    Math.Max(area, (j - i) * height[i++]) :
                    Math.Max(area, (j - i) * height[j--]);
            }
            return area;
        }
    }
}
