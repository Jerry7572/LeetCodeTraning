/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        // 1
        return nums.Distinct().Where(x => nums.Where(y => x == y).ToList().Count == 1).First();

        // 2
        int[] distinct = nums.Distinct().ToArray();
        nums = nums.OrderBy(x => x).ToArray();
        foreach (var item in distinct)
        {
            int index = Array.IndexOf(nums, item);
            if (index == nums.Length - 1)
            {
                return nums[index];
            }
            if (nums[index] != nums[index + 1])
            {
                return nums[index];
            }

        }
        return 0;

    }
}
// @lc code=end

// 61/61 cases passed (1290 ms)
// Your runtime beats 5.04 % of csharp submissions
// Your memory usage beats 5.96 % of csharp submissions (55.1 MB)

// 61/61 cases passed (153 ms)
// Your runtime beats 14.14 % of csharp submissions
// Your memory usage beats 10.87 % of csharp submissions (47.1 MB)