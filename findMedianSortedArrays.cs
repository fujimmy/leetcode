using System;
namespace leetcode
{
    public static class findMedianSortedArrays
    {
        /// <summary>
        /// 找出兩個排序數組的中位數
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            /* 
            二分查找說明:https://www.youtube.com/watch?v=RH3tZldhjJ0
            確保 nums1 是較短的數組（交換兩數組以簡化操作）。
            使用二分查找，在 nums1 中找到分割點 i，分割點 j 可由公式計算：j = (m + n + 1) / 2 - i。
            檢查分割條件是否滿足：
            nums1[i-1] <= nums2[j] 且 nums2[j-1] <= nums1[i]。
            根據分割條件計算中位數：
            如果總長度是奇數，中位數是左部分的最大值。
            如果總長度是偶數，中位數是左部分的最大值和右部分的最小值的平均值。 */

            int n1 = nums1.Length;
            int n2 = nums2.Length;
            if (n1 > n2) 
            {
                return FindMedianSortedArrays(nums2, nums1); //交換兩個數組，保證第一個數組更短。
            }
            int k = (n1 + n2 + 1) / 2; //中位數的位置
            int left = 0; 
            int right = n1;
            while (left < right)     
            {
                int m1 = left + (right - left) / 2;  
                int m2 = k - m1;    
                if (nums1[m1] < nums2[m2 - 1]) 
                {
                    left = m1 + 1;
                }
                else
                {
                    right = m1;
                }
            }
            int m1_ = left;
            int m2_ = k - left;
            int c1 = Math.Max(m1_ <= 0 ? int.MinValue : nums1[m1_ - 1],
                m2_ <= 0 ? int.MinValue : nums2[m2_ - 1]);
            if ((n1 + n2) % 2 == 1)
            {
                return c1;
            }
            int c2 = Math.Min(m1_ >= n1 ? int.MaxValue : nums1[m1_],
                m2_ >= n2 ? int.MaxValue : nums2[m2_]); 
            return (c1 + c2) * 0.5; //取平均數
        }
    }
}