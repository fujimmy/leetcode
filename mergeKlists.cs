using System.Collections.Generic;
using System;
using System.Linq;

namespace leetcode
{
    public static class mergeKLists
    {        
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (!lists.Any())
            {
                return null;
            }

            if (lists.Count() == 1)
            {
                return lists[0];
            }

            var mergedLists = new List<ListNode>();
            // 將兩個鏈表合併，然後將結果放入 mergedLists 中
            // 這樣可以減少合併的次數，從 O(k^2) 降低到 O(k log k)
            for (var i = 0; i < lists.Count(); i = i + 2)
            {
                // 如果還有兩個鏈表可以合併
                // 合併兩個鏈表
                // 將合併的結果放入 mergedLists 中
                // 這樣可以減少合併的次數，從 O(k^2) 降低到 O(k log k)
                // 這裡的 lists[i] 和 lists[i + 1] 是兩個鏈表的頭節點
                if (i < lists.Count() - 1)
                {
                    mergedLists.Add(MergeTwoLists(lists[i], lists[i + 1]));
                }
                else
                {
                    mergedLists.Add(lists[i]);
                }
            }
            return MergeKLists(mergedLists.ToArray());
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null)
            {
                return list2;
            }
            if (list2 is null)
            {
                return list1;
            }

            // 比較兩個鏈表的頭節點，將較小的節點放在前面
            // 並遞歸合併剩餘的部分
            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}