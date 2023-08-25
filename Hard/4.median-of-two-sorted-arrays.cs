/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int totalLength = nums1.Length + nums2.Length;
        int left = 0, right = 0, count = 0;
        int[] result = new int[totalLength];
        while (left < nums1.Length && right < nums2.Length)
        {
            if (nums1[left] < nums2[right])
            {
                result[count] = nums1[left];
                left++;
            }
            else
            {
                result[count] = nums2[right];
                right++;
            }
            count++;
        }
        while (left < nums1.Length)
        {
            result[count] = nums1[left];
            left++;
            count++;
        }
        while (right < nums2.Length)
        {
            result[count] = nums2[right];
            right++;
            count++;
        }
        return count % 2 == 0 ?
            (double)(result[count / 2] + result[(count / 2) - 1]) / 2 :
            (double)result[count / 2];
    }
}
// @lc code=end

// 2094/2094 cases passed (89 ms)
// Your runtime beats 93.84 % of csharp submissions
// Your memory usage beats 51.15 % of csharp submissions (52.5 MB)