using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class letterCombinations
    {
        private static readonly string[] mapping = new string[] {
        "",    // 0
        "",    // 1
        "abc", // 2
        "def", // 3
        "ghi", // 4
        "jkl", // 5
        "mno", // 6
        "pqrs",// 7
        "tuv", // 8
        "wxyz" // 9
    };

        public static IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }
            LetterCombinationsRecursive(result, digits, "", 0);
            return result;
        }

        private static void LetterCombinationsRecursive(List<string> result, string digits, string current, int index)
        {
            // 當 index 等於 digits 長度時，表示已經找到一個組合
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }
            //字符 '0' 的 ASCII 碼是 48
            //'2' - '0' = 50 - 48 = 2
            //速度會比conver to int快
            string letters = mapping[digits[index] - '0']; // 取得數字對應的字母 
            foreach (char letter in letters)
            {
                LetterCombinationsRecursive(result, digits, current + letter, index + 1);
            }
        }
    }
}