using System;
using System.Collections.Generic;
namespace leetcode
{
    public static class Palindrome
    {
        /// <summary>
        /// 判斷是否為回文數
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;//負數不是回文數

            List<int> storeNumber = new List<int>();
            while (x != 0)
            {
                storeNumber.Add(x % 10);//取最後一位數
                x /= 10;//去掉最後一位數
            }

            int length = storeNumber.Count;
            
            for (int i = 0; i < length / 2; i++)
            {

                if (storeNumber[i] != storeNumber[length - 1 - i])//比對是否相等
                    return false;
            }
            return true;
        }
    }
}