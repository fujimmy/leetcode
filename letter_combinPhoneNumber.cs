using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class letterCombinations
    {
        public static string[] LetterCombinations(string digits)
        {
            if (digits == null || digits.Length == 0)
                return [];

            // **手動建立數字對應字母的對照表**
            char[][] phoneMap =
            [
            [], [],  // 0 和 1 沒有對應
            ['a', 'b', 'c'],   // 2
            ['d', 'e', 'f'],   // 3
            ['g', 'h', 'i'],   // 4
            ['j', 'k', 'l'],   // 5
            ['m', 'n', 'o'],   // 6
            ['p', 'q', 'r', 's'], // 7
            ['t', 'u', 'v'],   // 8
            ['w', 'x', 'y', 'z']  // 9
            ];

            // **計算可能組合的數量**
            int totalCombinations = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                int num = digits[i] - '0';
                totalCombinations *= phoneMap[num].Length;
            }

            // **手動建立儲存結果的陣列**
            string[] result = new string[totalCombinations];
            char[] path = new char[digits.Length];  // 路徑存放目前組合

            // **手寫遞迴函式**
            int index = 0;
            GenerateCombinations(result, ref index, phoneMap, digits, 0, path);
            return result;
        }

        private static void GenerateCombinations(string[] result, ref int index, char[][] phoneMap,string digits, int depth, char[] path)
        {
            if (depth == digits.Length)
            {
                // **手動存入陣列**
                result[index] = new string(path);
                index++;
                return;
            }

            int digit = digits[depth] - '0';
            for (int i = 0; i < phoneMap[digit].Length; i++)
            {
                path[depth] = phoneMap[digit][i];  // 設置當前層的字母
                GenerateCombinations(result, ref index, phoneMap, digits, depth + 1, path);
            }
        }
    }
}