using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ReverseLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        public void Iterative(int[] numbers)
        {
            ListNode head = null;
            ListNode prevNode = null;
            foreach (var num in numbers)
            {
                var newNode = new ListNode(num);
                if (head == null)
                {
                    head = prevNode = newNode;
                }
                prevNode.next = newNode;
                prevNode = newNode;
            }

            Array.Reverse(numbers);
            var reversePointer = (new Solution()).ReverseListIterative(head);
            int currentIndex = 0;
            while (reversePointer != null)
            {
                Assert.AreEqual(numbers[currentIndex++], reversePointer.val);

                reversePointer = reversePointer.next;
            }
        }

        [TestMethod]
        public void IterativeEmpty()
        {
            var reversePointer = (new Solution()).ReverseListIterative(null);

            Assert.AreEqual(null, reversePointer);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        public void Recursive(int[] numbers)
        {
            ListNode head = null;
            ListNode prevNode = null;
            foreach (var num in numbers)
            {
                var newNode = new ListNode(num);
                if (head == null)
                {
                    head = prevNode = newNode;
                }
                prevNode.next = newNode;
                prevNode = newNode;
            }

            Array.Reverse(numbers);
            var reversePointer = (new Solution()).ReverseListRecursive(head);
            int currentIndex = 0;
            while (reversePointer != null)
            {
                Assert.AreEqual(numbers[currentIndex++], reversePointer.val);

                reversePointer = reversePointer.next;
            }
        }

        [TestMethod]
        public void RecursiveEmpty()
        {
            var reversePointer = (new Solution()).ReverseListRecursive(null);

            Assert.AreEqual(null, reversePointer);
        }
    }
}
