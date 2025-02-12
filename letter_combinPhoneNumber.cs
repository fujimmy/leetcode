using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class Solution
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
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }
            string letters = mapping[digits[index] - '0'];
            foreach (char letter in letters)
            {
                LetterCombinationsRecursive(result, digits, current + letter, index + 1);
            }
        }
    }
}