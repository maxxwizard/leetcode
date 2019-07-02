using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplyTwoIntegers
{
    class Solution
    {
        public static int multiplyIterative(int n, int m)
        {
            int threshold = int.MaxValue - n;
            int product = 0;
            bool answerIsNegative = false;
            for (int i = 0; i < m; i++)
            {
                if (product >= threshold) {
                    throw new ArgumentOutOfRangeException();
                }
                product += n;
            }
            return answerIsNegative ? 0 - product : product;
        }

        /// <summary>
        /// Product using no multiply, divide, modulus operators.
        /// </summary>
        /// <param name="n">Non-negative integer.</param>
        /// <param name="m">Non-negative integer.</param>
        public static int multiplyRecursive(int n, int m)
        {
            if (m == 0)
            {
                return 0;
            }

            if (m == 1)
            {
                return n;
            }

            // look at the least-significant bit to determine even or odd
            int z = m;
            z = z << 31;
            z = z >> 32;
            bool isEven = z == 0;

            if (isEven)
            {
                return multiplyRecursive(n, m >> 1) + multiplyRecursive(n, m >> 1);
            } else
            {
                return multiplyRecursive(n, m >> 1) + multiplyRecursive(n, m >> 1) + n;
            }
        }

        private bool answerIsNegative(int n, int m)
        {
            bool n_isNegative = n < 0;
            bool m_isNegative = m < 0;
            return n_isNegative ^ m_isNegative;
        }
    }
}
