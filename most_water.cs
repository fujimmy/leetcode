using System;

namespace leetcode
{
    public static class MostWater
    {
        /// <summary>
        /// 盛最多水的容器
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int ans = 0;
            int maxHeight = 0;

            while (left != right)
            {
                if (height[left] <= maxHeight)
                {
                    left++;
                    continue;
                }

                if (height[right] <= maxHeight)
                {
                    right--;
                    continue;
                }

                maxHeight = Math.Min(height[left], height[right]);

                int width = right - left;
                int area = width * maxHeight;

                if (area > ans)
                    ans = area;
                /*else
                    maxHeight = (int)Math.Ceiling((area + 1) / (width - 1d));*/
            }

            return ans;
        }
    }
}