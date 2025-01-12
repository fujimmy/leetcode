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
            if (numRows == 1)   
            {
                return s;
            }
            string[] rows = new string[numRows];        
            int currentRow = 0; 
            bool goingDown = false;
            foreach (char c in s)
            {                
                rows[currentRow] += c; //將字元加入對應的row
                if (currentRow == 0 || currentRow == numRows - 1)   //到頂或底時改變方向   
                {
                    goingDown = !goingDown; //改變方向 
                }
                currentRow += goingDown ? 1 : -1; //往下或往上
            }
            string result = "";
            foreach (string row in rows)
            {
                result += row;
            }
            return result;
        }
    }
}