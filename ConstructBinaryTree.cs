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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i < inorder.Length; i++)
            dict.Add(inorder[i], i);
        TreeNode root = buildTree(inorder, 0, inorder.Length - 1, preorder, 0, preorder.Length - 1, dict);
        return root;
    }
    
    private TreeNode buildTree(int[] inorder, int inStart, int inEnd, int[] preorder, int preStart, int preEnd, Dictionary<int,int> dict){
        if(inStart > inEnd || preStart > preEnd) return null;
        TreeNode root = new TreeNode(preorder[preStart]);
        int inRoot = dict[root.val];
        int numsLeft = inRoot - inStart;
        root.left = buildTree(inorder, inStart, inRoot + 1, preorder, preStart + 1, preStart + numsLeft, dict);
        root.right = buildTree(inorder, inRoot + 1, inEnd, preorder, preStart + numsLeft + 1, preEnd, dict);
        return root;
    }
}