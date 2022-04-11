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
    public int GoodNodes(TreeNode root) {
        int result = dfs(root, root.val);
        return result;
    }
    private int dfs(TreeNode root, int maxVal){
        if(root == null)
            return 0;
        int result = 0;
        if(root.val >= maxVal)
            result = 1;
        maxVal = Math.Max(maxVal, root.val);
        result += dfs(root.left, maxVal);
        result += dfs(root.right, maxVal);
        return result;
    }
}