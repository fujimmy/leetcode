using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class RemoveElement
    {
        public static int removeElement(int[] nums, int val)
        {
            int k = 0; // 新陣列的有效長度

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
            /*
              int k = 0; // 新陣列的有效長度

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
            */
        }
    }
}