/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }
        var dic = new Dictionary<string, string[]>
            {
                {"2", new string[]{"a", "b", "c"}}, {"3", new string[]{"d", "e", "f"}},
                {"4", new string[]{"g", "h", "i"}}, {"5", new string[]{"j", "k", "l"}},
                {"6", new string[]{"m", "n", "o"}}, {"7", new string[]{"p", "q", "r", "s"}},
                {"8", new string[]{"t", "u", "v"}}, {"9", new string[]{"w", "x", "y", "z"}}
            };
        List<string[]> stringArr = new List<string[]>();
        for (int i = 0; i < digits.Length; i++)
        {
            stringArr.Add(dic.GetValueOrDefault(digits[i].ToString()));
        }
        if (stringArr.Count == 1)
        {
            return stringArr[0].ToList();
        }

        List<string> result = stringArr[0].ToList();
        for (int i = 1; i < stringArr.Count; i++)
        {
            result = GetMergeStringArray(result.ToArray(), stringArr[i]);
        }

        return result;
    }

    private List<string> GetMergeStringArray(string[] strings1, string[] strings2)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < strings1.Length; i++)
        {
            for (int j = 0; j < strings2.Length; j++)
            {
                result.Add($"{strings1[i]}{strings2[j]}");
            }
        }
        return result;
    }


}
// @lc code=end

// 25/25 cases passed (86 ms)
// Your runtime beats 98.34 % of csharp submissions
// Your memory usage beats 7.16 % of csharp submissions (47.3 MB)