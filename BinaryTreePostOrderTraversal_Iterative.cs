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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        if(root == null)
            return list;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;
        TreeNode prev = null;
        while(cur != null || stack.Count != 0){
            if(cur != null){
                stack.Push(cur);
                cur = cur.left;
            }
            else{
                cur = stack.Peek();
                if(cur.right == null || cur.right == prev){
                    list.Add(cur.val);
                    stack.Pop();
                    prev = cur;
                    cur = null;
                }
                else
                    cur = cur.right;
            }
        }
        return list;
    }
}