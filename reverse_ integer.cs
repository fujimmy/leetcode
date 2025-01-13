using System.Collections.Generic;
using System;
namespace leetcode
{
    public static class ReverseInteger
    {
        /// <summary>
        /// 反轉整數
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int reverse(int x)
        {
            int result = 0;

            while (x != 0)  // 當x不等於0時
            {
                int digit = x % 10; // 取得最後一位數
                x /= 10;        // 去掉最後一位數

                // 檢查溢出（正數情況）
                if (result > (int.MaxValue / 10) || (result == int.MaxValue / 10 && digit > 7)) // 7是因為int.MaxValue的最後一位數是7
                    return 0;

                // 檢查溢出（負數情況）
                if (result < (int.MinValue / 10) || (result == int.MinValue / 10 && digit < -8))    // -8是因為int.MinValue的最後一位數是8
                    return 0;

                // 更新結果
                result = result * 10 + digit;   // 這裡是將result*10再加上digit
            }

            return result;
        }
    }
}