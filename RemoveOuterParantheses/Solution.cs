using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveOuterParantheses
{
    /// <summary>
    /// https://leetcode.com/problems/remove-outermost-parentheses/
    /// </summary>
    class Solution
    {
        public string RemoveOuterParentheses(string S)
        {
            // iterate the string building up temp substrings
            // when we reach a closing paranthesis where count of left and right are equal,
            // remove its outer parantheses
            var temp = string.Empty;
            int countLeft = 0, countRight = 0;
            var mainSB = new StringBuilder();
            foreach (char c in S)
            {
                temp += c;
                switch (c) {
                    case '(':
                        countLeft++;
                        break;
                    case ')':
                        countRight++;
                        if (countRight == countLeft)
                        {
                            countLeft = countRight = 0;
                            mainSB.Append(temp.Substring(1, temp.Length - 2));
                            temp = string.Empty;
                        }
                        break;
                    default:
                        throw new ArgumentException();
                }
            }

            return mainSB.ToString();
        }
    }
}
