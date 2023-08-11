/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 */

// @lc code=start
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    List<int> list = nums.Skip(i).Take(nums.Length - i).OrderBy(x => x).ToList();
                    int preIndex = list.IndexOf(nums[i]);

                    for (int l = preIndex; l < list.Count; l++)
                    {
                        if (list[l] > nums[i])
                        {
                            nums[i] = list[l];
                            list.RemoveAt(l);
                            break;
                        }
                    }
                    for (int l = 0; l < list.Count; l++)
                    {
                        nums[i + l + 1] = list[l];
                    }

                    return;
                }

            }
        }
        Array.Sort(nums);
        return;
    }
}
// @lc code=end

// 266/266 cases passed (127 ms)
// Your runtime beats 82.59 % of csharp submissions
// Your memory usage beats 12.03 % of csharp submissions (44 MB)