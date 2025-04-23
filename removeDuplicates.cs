using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class RemoveDuplicates
    {
        public static int removeDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int j = 0;
            // 使用雙指針法，j 指向不重複的元素的最後一個位置
            // i 指向當前遍歷的元素
            for (int i = 1; i < nums.Length; i++)
            {
                // 如果當前元素 nums[i] 與 nums[j] 不同，則將 nums[i] 放到 j+1 的位置
                // 並將 j 向前移動一位
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }

            return j + 1;
        }
    }
}