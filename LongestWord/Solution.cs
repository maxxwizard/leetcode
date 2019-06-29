using System;
using System.Collections.Generic;

namespace LongestWord
{
    /// <summary>
    /// https://leetcode.com/problems/longest-word-in-dictionary/
    /// </summary>
    class Solution
    {
        public string LongestWord(string[] words)
        {
            var longestWord = string.Empty;

            // sort the array
            Array.Sort(words);

            // walk the sorted array and add word only if its prefix already in set
            var set = new HashSet<string>();
            foreach (var word in words)
            {
                if (word.Length == 1 || set.Contains(word.Substring(0, word.Length - 1)))
                {
                    set.Add(word);
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }

            return longestWord;
        }
    }
}
