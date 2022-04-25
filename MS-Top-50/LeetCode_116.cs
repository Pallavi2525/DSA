//LeetCode - 116. Populating Next Right Pointers in Each Node

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Node cur = root;
        Node next = null;
        if(cur != null && cur.left != null)
            next = cur.left;
        while(cur != null && next != null){
            cur.left.next = cur.right;
            if(cur.next != null)
                cur.right.next = cur.next.left;
            cur = cur.next;
            if(cur == null)
            {
                cur = next;
                next = cur.left;
            }
        }
        return root;
    }
}