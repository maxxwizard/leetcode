using System;
using System.Collections.Generic;
using System.Text;

namespace LongestWord
{
    class Node
    {
        static int NUM_OF_CHARACTERS = 26;
        public Node[] children = new Node[NUM_OF_CHARACTERS];
        public string word = null;

        private int getCharValue(char c) => c - 'a';

        public Node(string word)
        {
            this.word = word;
        }

        private Node getNode(char c)
        {
            return children[getCharValue(c)];
        }

        private void setNode(char c, Node n)
        {
            children[getCharValue(c)] = n;
        }

        public bool contains(string word, int index)
        {
            if (index == word.Length)
            {
                return true;
            }

            char current = word[index];
            var currentNode = getNode(current);
            if (currentNode == null)
            {
                return false;
            }

            return currentNode.contains(word, index + 1);
        }

        private void addWord(string word, int index)
        {
            if (index == word.Length)
            {
                return;
            }

            var current = word[index];
            var currentNode = getNode(current);
            if (currentNode == null)
            {
                var newNode = new Node(word);
                setNode(current, newNode);
                currentNode = newNode;
            }

            currentNode.addWord(word, index + 1);
        }

        public override string ToString()
        {
            return word.ToString();
        }

        public void addWord(string word)
        {
            addWord(word, 0);
        }
    }
}
