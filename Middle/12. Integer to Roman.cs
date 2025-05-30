public class Solution
{
    public string IntToRoman(int num)
    {
        string output = "";
        string[] one = ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"];
        string[] ten = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"];
        string[] hun = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"];
        string[] tho = ["", "M", "MM", "MMM"];

        output += tho[num / 1000];
        output += hun[num % 1000 / 100];
        output += ten[num % 100 / 10];
        output += one[num % 10];

        return output;
    }
}
// 3999 / 3999 cases passed (2 ms)
// Your runtime beats 86.14% of csharp submissions
// Your memory usage beats 42.32% of csharp submissions (46.96 MB)