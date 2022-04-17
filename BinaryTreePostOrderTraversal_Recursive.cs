//LeetCode - 145. Binary Tree Postorder Traversal

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
        traverse(root, ref list);
        return list;
    }
    private void traverse(TreeNode node, ref List<int> list){
        if(node.left != null)
            traverse(node.left, ref list);
        if(node.right != null)
            traverse(node.right, ref list);
        list.Add(node.val);
    }
}