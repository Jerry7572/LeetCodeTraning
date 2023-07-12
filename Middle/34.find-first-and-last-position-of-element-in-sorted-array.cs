/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                if (result.Count == 2)
                {
                    result[1] = i;
                    continue;
                }
                result.Add(i);
            }
        }
        if (result.Count == 1)
        {
            result.Add(result[0]);
        }
        return result.Count == 0 ? new int[2] { -1, -1 } : result.ToArray();
    }
}
// @lc code=end

// 88/88 cases passed (178 ms)
// Your runtime beats 6.28 % of csharp submissions
// Your memory usage beats 78.63 % of csharp submissions (44.8 MB)