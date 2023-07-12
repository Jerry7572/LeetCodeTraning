/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution
{
    public int Search(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
// @lc code=end

// 195/195 cases passed (98 ms)
// Your runtime beats 15.09 % of csharp submissions
// Your memory usage beats 81.05 % of csharp submissions (39.1 MB)