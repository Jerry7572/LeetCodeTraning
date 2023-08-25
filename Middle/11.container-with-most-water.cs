/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        int result = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            bool bigger = height[left] < height[right];
            int hei = bigger ? height[left] : height[right];
            int temp = hei * (right - left);
            result = temp > result ? temp : result;
            if (bigger)
                left++;
            else
                right--;
        }
        return result;
    }
}
// @lc code=end

// 61/61 cases passed (153 ms)
// Your runtime beats 97.63 % of csharp submissions
// Your memory usage beats 89.54 % of csharp submissions (50.7 MB)