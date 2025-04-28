using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class FindIndex
    {
        public static int findIndex(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0; // 如果 needle 是空字符串，返回 0

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return i; // 找到匹配，返回起始索引
            }

            return -1; // 沒有找到匹配，返回 -1
        }
    }
}