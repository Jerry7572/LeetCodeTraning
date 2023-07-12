/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 */

// @lc code=start
public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }
        if (nums.Length == nums[0] + 1)
        {
            return 1;
        }
        int result = maxJump(nums, 0, 0);
        return result == 0 ? result + 1 : result;
    }
    public int maxJump(int[] nums, int nowIndex, int count)
    {
        if (nowIndex + nums[nowIndex] == nums.Length - 1)
        {
            return ++count;
        }
        if (nowIndex + nums[nowIndex] > nums.Length - 1)
        {
            return nowIndex == nums.Length - 1 ? count : ++count;
        }

        int nextIndex = 0;
        int value = 0;
        int max = 0;
        for (int i = 1; i <= nums[nowIndex]; i++)
        {
            if (nums[nowIndex + i] == 0)
            {
                continue;
            }
            int total = nums[nowIndex + i] + i;
            if (max <= total)
            {
                max = total;
                value = nums[nowIndex + i];
                nextIndex = i;
            }

        }
        if(max == 0){
            return count;
        }

        return maxJump(nums, nowIndex + nextIndex, ++count);
    }

}
// @lc code=end

// 109/109 cases passed (94 ms)
// Your runtime beats 90.27 % of csharp submissions
// Your memory usage beats 40.27 % of csharp submissions (42.8 MB)