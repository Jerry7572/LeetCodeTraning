/*
 * @lc app=leetcode id=29 lang=csharp
 *
 * [29] Divide Two Integers
 */
 
// @lc code=start
public class Solution {
    public int Divide(int dividend, int divisor) {
        if(dividend < 0 && divisor < 0){
            dividend = dividend == int.MinValue ? int.MaxValue : dividend * -1;
            divisor = divisor == int.MinValue ? int.MaxValue : divisor * -1;
        }
        return dividend / divisor;
    }
}
// @lc code=end

// 994/994 cases passed (30 ms)
// Your runtime beats 53.77 % of csharp submissions
// Your memory usage beats 55.48 % of csharp submissions (26.8 MB)