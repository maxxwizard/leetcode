using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    class Solution
    {
        public ListNode ReverseListIterative(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode prev = null, curr = head;
            while (curr != null)
            {
                var tempNext = curr.next;

                curr.next = prev;
                prev = curr;

                curr = tempNext;
            }

            return prev;
        }

        public ListNode ReverseListRecursive(ListNode head)
        {
            if (head == null || head.next == null)
            {
                // reached the end so return the new head
                return head;
            }

            var p = ReverseListRecursive(head.next);

            head.next.next = head;
            head.next = null;

            return p;
        }
    }
}
