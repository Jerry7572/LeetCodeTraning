/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 */

// @lc code=start
public class Solution
{
    public int UniquePaths(int m, int n)
    {
        if (n > m)
        {
            int temp = m;
            m = n;
            n = temp;
        }
        if (n - 1 <= 0)
        {
            return 1;
        }
        int totalStep = n + m - 2;

        return Convert.ToInt32(CalcuToEnd(totalStep, m) / CalcuToEnd(n - 1, 1));

    }

    public decimal CalcuToEnd(int head, int end)
    {
        decimal result = 1;
        for (int i = end; i <= head; i++)
        {
            result *= i;
        }
        
        return result;

    }

}
// @lc code=end

// 63/63 cases passed (14 ms)
// Your runtime beats 97.9 % of csharp submissions
// Your memory usage beats 60.36 % of csharp submissions (26.7 MB)