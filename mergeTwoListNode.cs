using System.Collections.Generic;
using System;
namespace leetcode
{
    public static class mergeTwoListNode
    {
        /// <summary>
        /// Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
        /// Example:
        /// Input: 1->2->4, 1->3->4
        /// Output: 1->1->2->3->4->4
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);// dummy node
            ListNode current = dummy;// current node

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)// compare the value of l1 and l2
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            if (l1 != null)// if l1 is not null, assign l1 to current.next
            {
                current.next = l1;
            }
            else
            {
                current.next = l2;
            }

            return dummy.next;

        }
    }
}