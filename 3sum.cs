using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class ThreeSum
    {        
        /// <summary>
        /// 3Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> threeSum(int[] nums)
        {
             QuickSort(nums, 0, nums.Length - 1); // 使用自己實作的排序
         
            //Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicates

                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; // Skip duplicates
                        while (left < right && nums[right] == nums[right - 1]) right--; // Skip duplicates
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
         // **快速排序 (QuickSort)**
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int pivotIndex = Partition(arr, left, right); // 找到基準點
            QuickSort(arr, left, pivotIndex - 1); // 左半部
            QuickSort(arr, pivotIndex + 1, right); // 右半部
        }

        static int Partition(int[] arr, int left, int right)
        {
            /*選擇 pivot（最後一個元素）
            把小於 pivot 的放左邊，大於的放右邊
            遞迴地對左右子陣列繼續 QuickSort
            當 left >= right，結束遞迴*/
            int pivot = arr[right]; // 以最右邊的數為基準
            int i = left - 1; // `i` 代表小於 pivot 的最後一個索引

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right); // 把 pivot 放到正確位置
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    
}