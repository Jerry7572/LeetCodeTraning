/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        string xStr = x.ToString();
        for (int i = 0; i < xStr.Length / 2; i++)
        {
            if (xStr[i] != xStr[xStr.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

// 11511/11511 cases passed (47 ms)
// Your runtime beats 62.7 % of csharp submissions
// Your memory usage beats 51.68 % of csharp submissions (30.1 MB)