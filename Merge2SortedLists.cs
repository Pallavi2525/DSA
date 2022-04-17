//LeetCode - 21. Merge Two Sorted Lists

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
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode resList = new ListNode();
        ListNode resHead = resList;
        while(list1 != null && list2!= null){
            if(list1.val <= list2.val){
                resHead.next = list1;
                list1 = list1.next;
            }
            else{
                resHead.next = list2;
                list2 = list2.next;
            }
            resHead = resHead.next;
        }
        resHead.next = list1 == null ? list2 : list1;
        return resList.next;
    }
}