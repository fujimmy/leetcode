using System.Collections.Generic;
using System;
namespace leetcode
{
    public static class TwoSum
    {
        /// <summary>
        /// 陣列內從0開始配對相加=target,回傳相加數的index
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] twosum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            //i+current=target
            //i=target-current
            for (int i = 0; i < nums.Length; i++)
            {
                int a = target - nums[i];
                if (map.ContainsKey(a))
                {  ////when match return.
                    return new int[] { map[a], i };
                }
                map[nums[i]] = i;
                foreach (var kvp in map)
                {
                    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }
            }
            return new int[] { };
        }


    }
}