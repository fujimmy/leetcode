using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class FourSum
    {
        public static IList<IList<int>> fourSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 4)
            {
                return Array.Empty<IList<int>>();
            }
            IList<IList<int>> result = new List<IList<int>>();
            int n = nums.Length;
            ThreeSum.QuickSort(nums, 0, n - 1);

            for (int i = 0; i < n - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue; // 跳過重複的數字

                long value = nums[i];

                long outerMinValue = value + nums[i + 1] + nums[i + 2] + nums[i + 3];
                if (outerMinValue > target)//如果最小值大於目標值，則跳出迴圈
                {
                    break;
                }          

                long outerMaxValue = value + nums[n - 1] + nums[n - 2] + nums[n - 3];
                if (outerMaxValue < target)//如果最大值小於目標值，則繼續下一輪迴圈
                {
                    continue;
                }

                for (int j = i + 1; j < n - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue; // 跳過重複的數字
                    int left = j + 1, right = n - 1;
                    while (left < right)
                    {
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });// Add to result
                            while (left < right && nums[left] == nums[left + 1]) left++; // Skip duplicates
                            while (left < right && nums[right] == nums[right - 1]) right--; // Skip duplicates
                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;//sum 小於目標值，移動 left 指針
                        }
                        else
                        {
                            right--;//sum 大於目標值，移動 right 指針
                        }
                    }
                }
            }
            return result;
        }
    }
}