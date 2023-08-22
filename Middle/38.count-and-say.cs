/*
 * @lc app=leetcode id=38 lang=csharp
 *
 * [38] Count and Say
 */

// @lc code=start
public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1) return "1";
        StringBuilder result = new StringBuilder();
        int nCount = 1;
        while (nCount < n)
        {
            string nStr = result.ToString() == "" ? "1" : result.ToString();
            result.Clear();
            int count = 0;
            char nTemp = nStr[0];
            for (int i = 0; i < nStr.Length; i++)
            {
                if (nTemp == nStr[i])
                {
                    count++;
                }
                else
                {
                    result.Append($"{count}{nTemp}");
                    nTemp = nStr[i];
                    count = 1;

                }
            }
            result.Append($"{count}{nTemp}");

            nCount++;
        }
        return result.ToString();
    }
}
// @lc code=end

// 30/30 cases passed (65 ms)
// Your runtime beats 85.67 % of csharp submissions
// Your memory usage beats 52.05 % of csharp submissions (39.2 MB)