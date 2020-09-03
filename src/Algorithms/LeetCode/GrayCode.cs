using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public class GrayCode
    {
        public List<int> Run(int n)
        {
            List<int> answer = new List<int>()
            { 
                0
            };

            int head = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = answer.Count - 1; j >= 0 ; j--)
                {
                    answer.Add(answer[j] + head);
                }
                head <<= 1;
            }
            return answer;
        }
    }
}
