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
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode mid = FindMiddle(head);
        ListNode left = head;
        ListNode right = mid.next;
        mid.next = null;

        return Merge(SortList(left), SortList(right));
    }

    private ListNode FindMiddle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }

    private ListNode Merge(ListNode left, ListNode right)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (left != null && right != null)
        {
            if (left.val < right.val)
            {
                current.next = left;
                left = left.next;
            }
            else
            {
                current.next = right;
                right = right.next;
            }
            current = current.next;
        }

        if (left != null)
        {
            current.next = left;
        }
        else if (right != null)
        {
            current.next = right;
        }

        return dummy.next;
    }
}
// @lc code=end

// 30/30 cases passed (124 ms)
// Your runtime beats 89.55 % of csharp submissions
// Your memory usage beats 31.82 % of csharp submissions (57.2 MB)