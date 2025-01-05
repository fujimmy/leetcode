using System;
namespace leetcode
{
    public static class Addtwonums
    {
        /// <summary>
        /// ListNode 相加的結果，回傳 將結果倒放進ListNode 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);

            //dummy 和 current 指向同一個物件（ListNode 節點）。
            //共享一個記憶體位置,後續變動都會影響dummy。
            //對 current.Next 進行操作時，
            //實際上是修改了 dummy 指向的那個節點的 Next 屬性。
            ListNode current = dummy;
            int carry = 0; //進位餘數

            while (l1 != null || l2 != null || carry > 0)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                carry = sum / 10; //進位
                current.next = new ListNode(sum % 10); //取餘數
                current = current.next;
            }

            return dummy.next;

        }
    }

    public class ListNode
    {
        public int val; // 节点存储的数据
        public ListNode next; // 指向下一个节点的引用

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}