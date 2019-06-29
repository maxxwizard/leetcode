using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleOfTheLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, 3)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 3)]
        public void TestMethod1(int[] numbers, int expectedAnswer)
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

            Assert.AreEqual(expectedAnswer, (new Solution()).MiddleNode(head).val);
        }
    }
}
