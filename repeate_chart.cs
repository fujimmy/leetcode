using System;
using System.Collections.Generic;
namespace leetcode
{
    public static class LengthOfLongest
    {
        /// <summary>
        /// 計算不重複字元最長度,Sliding Window方法
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            int max_length = 0;
            
            // 記錄每個字元最後出現的位置
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                //char已存在,start往右移動char index+1.
                if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start)
                {
                    start = charIndexMap[currentChar] + 1;
                }
                charIndexMap[currentChar] = i;
                max_length = Math.Max(max_length, i - start + 1);
            }    
            return max_length;
        }
    }
}