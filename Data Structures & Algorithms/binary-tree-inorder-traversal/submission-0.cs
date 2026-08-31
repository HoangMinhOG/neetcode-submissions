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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> order = new List<int>();
        if(root == null){
            return order;
        }
        order.AddRange(InorderTraversal(root.left));
        order.Add(root.val);
        order.AddRange(InorderTraversal(root.right));
        return order;
    }
}