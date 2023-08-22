/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode result = new ListNode();
        ListNode current = result;
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        while (list1 != null && list2 != null)
        {
            if(list1.val < list2.val){
                current.next = list1;
                list1 = list1.next;
            }else{
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        if(list1 != null){
            current.next = list1;
        }
        if(list2 != null){
            current.next = list2;
        }
        return result.next;
    }
}
// @lc code=end

// 208/208 cases passed (82 ms)
// Your runtime beats 70 % of csharp submissions
// Your memory usage beats 62.27 % of csharp submissions (39.9 MB)