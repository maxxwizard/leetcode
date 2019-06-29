using System;
using System.Collections.Generic;
using System.Text;

namespace LongestWord
{
    class Trie
    {
        Node _root;

        public Trie(string[] words)
        {
            _root = new Node(string.Empty);
            Array.Sort(words);
            foreach (var word in words)
            {
                switch (word.Length)
                {
                    case 0:
                        break;
                    case 1:
                        _root.addWord(word);
                        break;
                    default:
                        bool containsPrefix = contains(word.Substring(0, word.Length - 1));
                        if (containsPrefix)
                        {
                            _root.addWord(word);
                        }
                        break;
                }
            }
        }

        public bool contains(string word)
        {
            return _root.contains(word, 0);
        }

        // run depth-first search (DFS) and remember longest word
        private string findLongestWord(Node current)
        {
            string longestWord = string.IsNullOrEmpty(current.word) ? string.Empty : current.word;
                        
            foreach (var child in current.children)
            {
                if (child == null || child.word == null)
                {
                    continue;
                }
                var potential = findLongestWord(child);
                if (potential.Length > longestWord.Length)
                {
                    longestWord = potential;
                }
            }
            
            return longestWord;
        }

        public string getLongestWord()
        {
            return findLongestWord(_root);
        }
    }
}
