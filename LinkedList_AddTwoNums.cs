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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var result = new ListNode();
        var first = result;
        int remainder = 0;
        int curr = 0;
        while(true){
            curr = remainder + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
            result.val = curr%10;
            remainder = curr/10;
            if(l1 != null)
                l1 = l1.next;
            if(l2 != null)
                l2 = l2.next;
            if(l1 == null && l2 == null && remainder == 0)
                return first;
            result.next = new ListNode();
            result =  result.next;
        }
    }
}