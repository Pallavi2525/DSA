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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode list = head;
        while(list != null){
            ListNode temp = list.next;
            while(temp!= null && temp.val == list.val){
                temp = temp.next;
            }
            list.next = temp;
            list = list.next;
        }
        return head;
    }
}