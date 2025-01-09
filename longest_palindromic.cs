using System;
using System.Collections.Generic;
namespace leetcode
{
    public static class Longest_palindromic
    {
        /// <summary>
        /// 找出最長的回文子串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int longest_palindromic(string s)
        {
            int max_length = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start)    //char已存在,start往右移動char index+1.
                {
                    start = charIndexMap[currentChar] + 1;  //start往右移動char index+1.
                }
                charIndexMap[currentChar] = i;  //記錄每個字元最後出現的位置
                max_length = Math.Max(max_length, i - start + 1);   //取最大長度
            }
            return max_length;
        }
    }
}