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
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<int> list = new List<int>();
        if(root!=null){
            queue.Enqueue(root);
        }
        while(queue.Count>0){
            TreeNode rightNode = new TreeNode();
            int level = queue.Count;
            for(int i=0;i<level;i++){
                TreeNode curr = queue.Dequeue();
                rightNode = curr;
                if(curr.left!=null){
                    queue.Enqueue(curr.left);
                }
                if(curr.right!=null){
                    queue.Enqueue(curr.right);
                }
            }
            list.Add(rightNode.val);
        }
        return list;
    }
}
