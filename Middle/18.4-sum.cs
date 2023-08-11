/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                // Skip duplicates for i
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                int left = j + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    double sum = nums[i];
                    sum += nums[j];
                    sum += nums[left];
                    sum += nums[right];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

        }
        return result;
    }
}
// @lc code=end

// 293/293 cases passed (127 ms)
// Your runtime beats 99.16 % of csharp submissions
// Your memory usage beats 68.63 % of csharp submissions (44.1 MB)