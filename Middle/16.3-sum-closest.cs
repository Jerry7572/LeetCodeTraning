/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 */

// @lc code=start
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int closestSum = nums[0] + nums[1] + nums[2];
        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++)
        {
            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == target)
                    return sum;

                // 更新最接近目標值的和
                if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                    closestSum = sum;

                if (sum < target)
                    left++;
                else
                    right--;
            }
        }

        return closestSum;
    }
}
// @lc code=end

// 99/99 cases passed (91 ms)
// Your runtime beats 90.6 % of csharp submissions
// Your memory usage beats 66.4 % of csharp submissions (39.6 MB)