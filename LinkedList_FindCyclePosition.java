/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode detectCycle(ListNode head) {
        if(head == null || head.next == null)
            return null;
        ListNode S = head;
        ListNode F = head;
        while(F!= null && F.next!=null && S!=null){
            F = F.next.next;
            S = S.next;
            if(F == S)
            {
                ListNode S2 = head;
                while(S2 != S){
                    S = S.next;
                    S2 = S2.next;
                }
                return S;
            }
        }
        return null;
    }
}