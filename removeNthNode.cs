using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class RemoveNthNode
    {
        public static ListNode removeNthFromEnd(ListNode head, int n)
        {
            if (head == null)
            {
                return null;
            }
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode slow = dummy;
            ListNode fast = dummy;
            for (int i = 0; i < n; i++)//快指針先走 n 步
            {
                fast = fast.next;
            }
            while (fast.next != null)
            {// 同時移動 fast 和 slow，直到 fast 到達尾部
                slow = slow.next;
                fast = fast.next;
            }
            slow.next = slow.next.next;// 刪除 slow.next (倒數第 n 個節點)
            return dummy.next;
        }
    }
}