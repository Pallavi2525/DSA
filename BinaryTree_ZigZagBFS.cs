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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if(root == null)
            return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool orderFlag = false;  //0= LR, 1=RL
        while(queue.Count != 0){
            int size = queue.Count;
            List<int> list = new List<int>();
            for(int i = 0; i < size; i++){
                root = queue.Dequeue();
                list.Add(root.val);
                if(root.left != null){
                    queue.Enqueue(root.left);
                }
                if(root.right != null){
                    queue.Enqueue(root.right);
                }
            }
            if(orderFlag)
                list.Reverse();
            orderFlag = !orderFlag;
            result.Add(list);
        }
        return result;
    }
}