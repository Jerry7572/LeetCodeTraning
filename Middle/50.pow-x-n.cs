/*
 * @lc app=leetcode id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution
{
    public double MyPow(double x, int n)
    {
        if(x == 1 || x== 0) return x;
        if(x == -1) return n % 2 == 0 ? 1 : -1;

        double result = 1;
        if (n < 0)
        {
            x = 1 / x;
            n = -n;
        }
        while (n != 0)
        {
            result *= x;
            if (result > 0 && result < 0.00001)
            {
                return 0;
            }
            --n;
        }
        return result;
    }
}
// @lc code=end

// 306/306 cases passed (2417 ms)
// Your runtime beats 5.77 % of csharp submissions
// Your memory usage beats 75.06 % of csharp submissions (26.9 MB)