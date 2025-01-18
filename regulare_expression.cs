using System;
using System.Collections.Generic;
namespace leetcode
{
    public static class Regularexpression
    {
        /// <summary>
        /// 判斷是否匹配
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        public static bool  IsMatch(string s, string p)
        {

            int m = s.Length, n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];

            // 初始化
            dp[0, 0] = true; // 空字串與空模式匹配
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 2]; // 處理 "x*" 的情況
                }
            }

            // 填充 DP 表
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    {
                        dp[i, j] = dp[i - 1, j - 1]; // 字符匹配
                    }
                    else if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i, j - 2] || // 忽略 "x*"
                                  (dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.')); // 匹配多個
                    }
                }
            }

            return dp[m, n];

        }
    }
}