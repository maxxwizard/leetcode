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
            _root = new Node('*');
            foreach (var word in words)
            {
                _root.addWord(word);
            }
        }

        public bool contains(string word)
        {
            return _root.contains(word, 0);
        }

        public string getLongestWord()
        {
            string largestWord = string.Empty;

            // run depth-first search (DFS) and remember longest word
            var stack = new Stack<Node>();
            stack.Push(_root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                // TODO
            }
            
            return largestWord;
        }
    }
}
