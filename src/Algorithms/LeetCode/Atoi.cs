using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode
{
    public class Atoi
    {
        private const string START_STATE = "start";
        private const string SIGN_STATE = "sign";
        private const string NUMBER_STATE = "number";
        private const string END_STATE = "end";

        private readonly Dictionary<string, string[]> state_table = new Dictionary<string, string[]>
        {
            [START_STATE] = new string[4] { START_STATE, SIGN_STATE, NUMBER_STATE, END_STATE },
            [SIGN_STATE] = new string[4] { END_STATE, END_STATE, NUMBER_STATE, END_STATE },
            [NUMBER_STATE] = new string[4] { END_STATE, END_STATE, NUMBER_STATE, END_STATE },
            [END_STATE] = new string[4] { END_STATE, END_STATE, END_STATE, END_STATE }
        };

        private string currentState = START_STATE;
        private int sign = 1;

        public int Run(string str)
        {
            currentState = START_STATE;
            sign = 1;
            long answer = 0;
            ReadOnlySpan<char> charSpan = str.AsSpan();
            bool end = false;
            foreach (char c in charSpan)
            {
                if (end) break;
                GetState(c);
                switch (currentState)
                {
                    case SIGN_STATE: sign = c == '-' ? -1 : 1; break;
                    case NUMBER_STATE:
                        {
                            answer = answer * 10 + c - '0';
                            answer = sign == 1 ? Math.Min(answer, int.MaxValue) : Math.Min(answer, -(long)int.MinValue);
                        }
                        break;
                    case END_STATE: end = true; break;
                    default:
                        break;
                }
            }
            return (int)answer * sign;
        }

        /// <summary>
        /// the equation of transform state
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private void GetState(char c)
        {
            int index = c switch
            {
                ' ' => 0,
                var temp when temp == '+' || temp == '-' => 1,
                var temp when IsDigit(temp) => 2,
                _ => 3
            };
            currentState = state_table[currentState][index];
        }

        private bool IsDigit(char c)
        {
            int n = c - '0';
            return n >= 0 && n <= 9;
        }
    }
}
