using System.Collections.Generic;
using System;
namespace leetcode
{
    public static class validParentheses
    {
        /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.  
        /// An input string is valid if:
        /// Open brackets must be closed by the same type of brackets.
        /// Open brackets must be closed in the correct order.
        /// Note that an empty string is also considered valid.
        /// Example 1:
        /// Input: "()"
        /// Output: true
        public static bool IsValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            // 自訂的 Stack
            char[] stack = new char[s.Length];
            int top = -1; // Stack 的頂部指標

            foreach (char c in s)
            {
                // 如果是左括號，手動 push 進 stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack[++top] = c; // 先增加 top 再存入
                }
                else
                {
                    // 如果 stack 為空，表示沒有對應的左括號
                    if (top == -1) return false;

                    char topElement = stack[top--]; // 先取出再減少 top

                    // 檢查是否匹配
                    if ((c == ')' && topElement != '(') ||
                        (c == '}' && topElement != '{') ||
                        (c == ']' && topElement != '['))
                    {
                        return false;
                    }
                }
            }
            // 如果堆疊為空，表示所有括號都匹配成功
            return top == -1;
        }
    }
}