using System;
namespace leetcode
{
    public static class dividetwoint
    {
        public static int Divide(int dividend, int divisor)
        {
            int INT_MAX = int.MaxValue;
            int INT_MIN = int.MinValue;

            // 特例處理：避免 overflow
            if (dividend == INT_MIN && divisor == -1)
            {
                return INT_MAX;
            }

            // 判斷結果正負號
            bool negative = (dividend < 0) ^ (divisor < 0);

            // 轉成 long 並取絕對值，避免 overflow（尤其是 INT_MIN）
            long lDividend = Math.Abs((long)dividend);
            long lDivisor = Math.Abs((long)divisor);

            long result = 0;

            // 位移優化版除法
            while (lDividend >= lDivisor)
            {
                long temp = lDivisor, multiple = 1;
                while (lDividend >= (temp << 1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }
                lDividend -= temp;
                result += multiple;
            }

            // 根據符號回傳結果
            result = negative ? -result : result;

            // 確保結果在 int 範圍內
            if (result > INT_MAX) return INT_MAX;
            if (result < INT_MIN) return INT_MIN;

            return (int)result;
        }
    }
}