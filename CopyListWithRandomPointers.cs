/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        Node iter = head;
        Node front = head;
        
        //creating the merged linked list - orignal and deep copy
        while(iter != null){
            front = iter.next;
            Node copy = new Node(iter.val);
            iter.next = copy;
            copy.next = front;
            iter = front;
        }
        
        //pointing the random pointers to the nodes in the deep copy nodes
        iter = head;
        while(iter != null){
            if(iter.random != null)
                iter.next.random = iter.random.next;
            iter = iter.next.next;
        }
        
        //separating the merged lists to get the original & deep copy
        iter = head;
        Node dummy = new Node(0);
        Node copyNode = dummy;
        while(iter != null){
            front = iter.next.next;
            copyNode.next = iter.next;
            copyNode = copyNode.next;
            iter.next = front;
            iter = front;
        }
        return dummy.next;
    }
}