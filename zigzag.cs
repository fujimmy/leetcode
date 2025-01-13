using System;
using System.Collections.Generic;
using System.Text;
namespace leetcode
{
    public static class Zigzag
    {
        /// <summary>
        /// 將字串轉換成Z字形
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
                return s;

            // 初始化行的列表
            List<StringBuilder> rows = new List<StringBuilder>();
            for (int i = 0; i < Math.Min(numRows, s.Length); i++)
                rows.Add(new StringBuilder());

            int currentRow = 0; // 當前行
            bool goingDown = false; // 初始方向

            // 遍歷字串中的每個字元
            foreach (char c in s)
            {
                rows[currentRow].Append(c);

                // 改變方向的條件
                if (currentRow == 0 || currentRow == numRows - 1)
                    goingDown = !goingDown;

                // 根據方向改變行數
                currentRow += goingDown ? 1 : -1;
            }

            // 將所有行合併成結果字串
            StringBuilder result = new StringBuilder();
            foreach (var row in rows)
                result.Append(row);

            return result.ToString();
        }
    }
}