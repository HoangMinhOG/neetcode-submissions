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
    public int KthSmallest(TreeNode root, int k) {
        List<int> list = inOrder(root);
        return list[k-1];
        
    }
    public List<int> inOrder(TreeNode root){
        List<int> order  = new List<int>();
        if(root==null) return order;
        order.AddRange(inOrder(root.left));
        order.Add(root.val);
        order.AddRange(inOrder(root.right));
        return order;

    }
}
