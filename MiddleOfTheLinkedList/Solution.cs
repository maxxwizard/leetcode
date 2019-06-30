namespace MiddleOfTheLinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/middle-of-the-linked-list/
    /// </summary>
    class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            // have a "slow" and "fast" iterator
            // slow iterator moves 1 node while fast iterator moves 2 nodes
            // when fast.next.next is null, it means slow is at the middle of list
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
