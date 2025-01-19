using System;

namespace leetcode
{
    public static class IntegerToRoman
    {
        private static readonly string[] thousands = { "", "M", "MM", "MMM" };

        private static readonly string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

        private static readonly string[] tens = { "",  "X",  "XX",  "XXX",  "XL",
                                              "L", "LX", "LXX", "LXXX", "XC" };

        private static readonly string[] ones = { "",  "I",  "II",  "III",  "IV",
                                              "V", "VI", "VII", "VIII", "IX" };
        /// <summary>
        /// 整數轉羅馬數字
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IntToRoman(int num)
        {            
            return thousands[num / 1000] + hundreds[(num % 1000) / 100] + tens[(num % 100) / 10] + ones[num % 10];//取千位數、百位數、十位數、個位數
        }
    }
}