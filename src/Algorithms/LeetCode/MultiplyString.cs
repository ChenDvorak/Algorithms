using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    public class MultiplyString
    {
        public string Run(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            string answer = "";

            for (int i = num2.Length - 1; i >= 0; i--)
            {
                int carry = 0;
                //  以相反的顺序保存乘积
                StringBuilder temp = new StringBuilder(num1.Length);
                for (int j = 0; j < num2.Length - i -1; j++)
                {
                    temp.Append(0);
                }

                int singleNumber = num2[i] - '0';

                for (int j = num1.Length - 1; j >=0 || carry != 0 ; j--)
                {
                    int n = j < 0 ? 0 : num1[j] - '0';
                    int value = (singleNumber * n + carry);
                    int product = value % 10;
                    carry = value / 10;
                    temp.Append(product);
                }
                answer = AddStrings(temp.ToString().Reverse().ToString(), answer);
            }
            return answer;
        }

        private string AddStrings(string s1, string s2)
        {
            StringBuilder sum = new StringBuilder(5);
            int carry = 0;
            for (int i = s1.Length - 1, j = s2.Length - 1; i >= 0 || j >= 0 || carry > 0; i--, j--)
            {
                int x = i < 0 ? 0 : s1[i] - '0';
                int y = j < 0 ? 0 : s1[j] - '0';
                int value = x + y + carry;
                sum.Append(value);
                carry = value / 10;
            }
            return sum.ToString().Reverse().ToString();
        }
    }
}
