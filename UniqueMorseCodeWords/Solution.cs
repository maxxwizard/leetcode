using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueMorseCodeWords
{
    /// <summary>
    /// https://leetcode.com/problems/unique-morse-code-words
    /// </summary>
    class Solution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var charMap = new string[26]
            {
                ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
            };

            var seen = new HashSet<string>();

            foreach (var word in words)
            {
                seen.Add(WordToMorse(word, charMap));
            }

            return seen.Count;
        }

        private string WordToMorse(string word, string[] morseCharMap)
        {
            var sb = new StringBuilder();
            foreach (var c in word)
            {
                sb.Append(morseCharMap[c - 'a']);
            }
            return sb.ToString();
        }
    }
}
