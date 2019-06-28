using System;
using System.Diagnostics;
using System.Linq;

namespace Contacts
{
    /// <summary>
    /// https://www.youtube.com/watch?v=vlYZb68kAY0
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new Node();
            rootNode.add("gayle", 0);
            rootNode.add("gary", 0);
            rootNode.add("geena", 0);
            rootNode.add("alex", 0);
            rootNode.add("andy", 0);

            Debug.Assert(rootNode.findCount("gayle", 0) == 1);
            Debug.Assert(rootNode.findCount("ga", 0) == 2);
        }
    }

    class Node
    {
        private static int NUM_OF_CHARACTERS = 26;
        Node[] children = new Node[NUM_OF_CHARACTERS];
        int size = 0;

        private int getCharValue(char c)
        {
            return c - 'a';
        }

        private Node getNode(char c)
        {
            return children[getCharValue(c)];
        }

        private void setNode(char c, Node node)
        {
            children[getCharValue(c)] = node;
        }

        public void add(string s, int index)
        {
            // if our index is greater than or equal to s.Length, we do nothing
            // else we add a node at s[index] and call add for the next index against that new node
            size++;

            if (index >= s.Length)
            {
                return;
            }

            var current = s[index];
            Node childNode = getNode(current);

            if (childNode == null)
            {
                childNode = new Node();
                setNode(current, childNode);
            }

            childNode.add(s, index + 1);
        }

        public int findCount(string s, int index)
        {
            if (index == s.Length)
            {
                return size;
            }

            var current = s[index];
            var childNode = getNode(current);
            if (childNode == null) // character match
            {
                return 0;
            }

            return childNode.findCount(s, index + 1); // move downwards in the trie
        }
    }
}
