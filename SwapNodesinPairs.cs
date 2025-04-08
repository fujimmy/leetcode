using System.Collections.Generic;
using System;
namespace leetcode
{
    public static class swap_nodes_in_pairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var first = head;
            var second = head.next;

            first.next = SwapPairs(second.next);// 遞歸調用，將第二個節點的下一個節點傳入
            second.next = first;

            return second;
        }
    }
}
/*遞迴的處理流程是：
🔽「先一路呼叫到底部」→ 🔼「再從最後一層一步步返回來處理」*/