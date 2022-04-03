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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> list = new List<int>();
        if(root == null)
            return list;
        return traverse(root,list);
    }
    private IList<int> traverse(TreeNode node, IList<int> list){
        if(node.left != null)
            traverse(node.left,list);
        list.Add((node.val));
        if(node.right != null)
            traverse(node.right,list);
        return list;
    }
}