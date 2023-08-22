/*
 * @lc app=leetcode id=148 lang=csharp
 *
 * [148] Sort List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode SortList(ListNode head)
    {
        List<int> list = new List<int>();
        var temp = head;
        while (temp != null)
        {
            list.Add(temp.val);
            temp = temp.next;
        }
        list.Sort();
        list.ForEach(x => Console.WriteLine(x));
        temp = new ListNode();
        ListNode result = new ListNode(0, temp);
        for (int i = 0; i < list.Count; i++)
        {
            temp.next = new ListNode(list[i]);
            temp = temp.next;
        }

        // list.ForEach(x => Console.WriteLine(x));
        return result.next.next;

    }
}
// @lc code=end

// 30/30 cases passed (204 ms)
// Your runtime beats 11.01 % of csharp submissions
// Your memory usage beats 8.72 % of csharp submissions (60.2 MB)