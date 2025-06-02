public class Solution
{
    public int RomanToInt(string s)
    {
        int[] n = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] dic = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
        int i = 0;
        int sIndex = 0;
        int result = 0;
        while (s.Length > sIndex)
        {
            if (s.Length - sIndex == 1)
            {
                if (dic[i] == s[sIndex].ToString())
                {
                    result += n[i];
                    sIndex++;
                    i = 0;
                }
                else { i++; }
            }
            else if (dic[i] == s.Substring(sIndex, dic[i].Length))
            {
                result += n[i];
                sIndex += dic[i].Length;
                i = 0;
            }
            else { i++; }
        }
        return result;
    }

    // 結果過於糟糕所以問了gpt後他有給我些建議
    // 因為羅馬字的特性(IV=4, V=5, VI=6)所以只需要判斷前一個是否有比目前大的狀況即可
    // 間接省下Substring()的空間及判斷字數為1 or 2
    // 原本為int[]及string[]裝著對照的東西, 使用Dictionary即可使用得到所需物不須一個個比對
    public int RomanToInt(string s)
    {
        var romanMap = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int result = 0;
        int prev = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int curr = romanMap[s[i]];
            if (curr < prev)
                result -= curr;
            else
                result += curr;
            prev = curr;
        }
        return result;
    }
}

// 3999/3999 cases passed (8 ms)
// Your runtime beats 14.52 % of csharp submissions
// Your memory usage beats 5.16 % of csharp submissions (54.88 MB)




