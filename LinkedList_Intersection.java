/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode getIntersectionNode(ListNode headA, ListNode headB) {
        while(headA != null){
            ListNode tmp = headB;
            while(tmp != null){
                if(tmp == headA) return headA;
                tmp = tmp.next;
            }
            headA = headA.next;
        }
        return null;
    }
}