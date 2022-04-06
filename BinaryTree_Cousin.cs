/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsCousins(TreeNode root, int x, int y) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count != 0){
            int size = queue.Count;
            bool isXExist = false;
            bool isYExist = false;
            for(int i = 0; i < size; i++){
                TreeNode cur = queue.Dequeue();
                if(cur.val == x) isXExist = true;
                if(cur.val == y) isYExist = true;
                if(cur.left != null && cur.right != null){
                    if(cur.left.val == x && cur.right.val == y)
                        return false;
                    else if(cur.left.val == y && cur.right.val == x)
                        return false;
                }
                if(cur.left != null)
                    queue.Enqueue(cur.left);
                if(cur.right != null)
                    queue.Enqueue(cur.right);
            }
            if(isXExist && isYExist) return true;
        }
        return false;
    }
}