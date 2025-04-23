using System.Collections.Generic;
using System;
namespace leetcode
{
    public static class ReverseNodesinKgroup
    {
        /// <summary>
        /// 給定一個鏈表，將每 k 個節點反轉一次。
        /// 例如：給定鏈表 1->2->3->4->5，k=2，則反轉後的鏈表為 2->1->4->3->5。
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ListNode reverseNodesinKgroup(ListNode head, int k)
        {
            // Step 1: 計算總長度
            var current = head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            // Step 2: 建立 dummy 節點和初始化
            var dummy = new ListNode(0);
            dummy.next = null;
            var lastNode = dummy;
            current = head;

            // Step 3: 每段處理 k 個節點
            while (count >= k)
            {
                ListNode prev = null;
                ListNode first = current;

                // 反轉 k 個節點
                for (int i = 0; i < k; i++)
                {
                    var next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }

                // 接上上一段與下一段
                lastNode.next = prev;
                lastNode = first;

                count -= k;
            }

            // 剩下不足 k 的節點原樣接上
            lastNode.next = current;

            return dummy.next;
        }
    }
}