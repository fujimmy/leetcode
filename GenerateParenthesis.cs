using System;
using System.Collections.Generic;


namespace leetcode
{
    public static class generateParenthesis
    {
        /// <summary>
        /// 括號生成
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            Generate(result, "", 0, 0, n);
            return result;
        }

        private static void Generate(IList<string> result, string current, int open, int close, int max)
        {
            if (current.Length == max * 2)  // 2n個括號
            {
                result.Add(current); // 當前字串長度等於2n，表示已經生成了一組合法的括號組合
                return;
            }

            if (open < max)// 開括號數量小於n，則可以添加開括號                // 這裡的open和close是當前字串中開括號和關括號的數量
                Generate(result, current + "(", open + 1, close, max);
            if (close < open)// 關括號數量小於開括號數量，則可以添加關括號
                Generate(result, current + ")", open, close + 1, max);
        }       
    }
}