/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode removeNthFromEnd(ListNode head, int n) {
        if(head == null)
            return null;
        ListNode n1 = head;
        ListNode n2 = head;
        int i = 1;
        while(i <= n){
            n1 = n1.next;
            i++;
        }
        if(n1 == null)
            return head.next;
        while(n1.next != null){
            n1 = n1.next;
            n2 = n2.next;
        }
        n2.next = n2.next.next;
        return head;
    }
}