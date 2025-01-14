using System;

namespace leetcode
{
    public static class Stringtoint
    {
        /// <summary>
        /// 將字串轉換成整數
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int stringtoint(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) // 檢查是否為空或只有空白字符
            {
                throw new ArgumentException("Input string is null or empty.");
            }

            str = str.Trim(); // 去掉前後空白字符
            int sign = 1;     // 用於標記正負號
            int index = 0;
            long result = 0;  // 使用 long 避免溢出

            // 檢查首字符是否為符號
            if (str[0] == '-')
            {
                sign = -1;
                index++;
            }
            else if (str[0] == '+')
            {
                index++;
            }

            // 循環解析每個數字字符
            while (index < str.Length && char.IsDigit(str[index]))
            {
                result = result * 10 + (str[index] - '0');

                // 檢查溢出（防止超過 int 範圍）
                if (result * sign > int.MaxValue)
                {
                    return int.MaxValue;
                }
                if (result * sign < int.MinValue)
                {
                    return int.MinValue;
                }

                index++;
            }

            // 返回最終結果
            return (int)(result * sign);
        }
    }
}