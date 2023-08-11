/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode node = new ListNode(0, head);
        ListNode slow = node;
        ListNode fast = head;
        while (n > 1)
        {
            fast = fast.next;
            n--;
        }

        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return node.next;
    }
}
// @lc code=end

// 208/208 cases passed (67 ms)
// Your runtime beats 99.24 % of csharp submissions
// Your memory usage beats 10.08 % of csharp submissions (39.2 MB)