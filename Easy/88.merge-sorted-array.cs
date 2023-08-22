/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var temp = nums1.Take(m).ToArray();
        if (n == 0) return;
        int left = 0;
        int right = 0;
        int index = 0;

        while (left < m && right < n)
        {

            if (temp[left] <= nums2[right])
            {
                nums1[index] = temp[left];
                left++;
            }
            else
            {
                nums1[index] = nums2[right];
                right++;
            }
            index++;
        }

        while (left < m)
        {
            nums1[index] = temp[left];
            left++;
            index++;

        }
        while (right < n)
        {
            nums1[index] = nums2[right];
            right++;
            index++;

        }

    }
}
// @lc code=end

// 59/59 cases passed (135 ms)
// Your runtime beats 60.97 % of csharp submissions
// Your memory usage beats 71.48 % of csharp submissions (43 MB)