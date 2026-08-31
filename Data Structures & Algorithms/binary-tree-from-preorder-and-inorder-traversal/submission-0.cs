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
        if(preorder.Length<1){
            return null;
        }
        int root1 = preorder[0];
        TreeNode root = new TreeNode(root1);
        int rootIndex = 0;
        for(int i=0;i<inorder.Length;i++){
            if(inorder[i]==root1){
                break;
            }
            else{
                rootIndex++;
            }
        }
        int[] leftInOrder = new int[rootIndex];
        int[] leftPreOrder = new int[rootIndex];
        int[] rightInOrder = new int[inorder.Length-rootIndex-1];
        int[] rightPreOrder = new int[inorder.Length-rootIndex-1];
        for(int i=0;i<leftPreOrder.Length;i++){
            leftPreOrder[i]=preorder[i+1];
        }
        for(int i=0;i<rightPreOrder.Length;i++){
            rightPreOrder[i]=preorder[i+rootIndex+1];
        }
        for(int i=0;i<leftInOrder.Length;i++){
            leftInOrder[i]=inorder[i];
        }
        for(int i=0;i<rightInOrder.Length;i++){
            rightInOrder[i]=inorder[rootIndex+i+1];
        }
        root.left = BuildTree(leftPreOrder, leftInOrder);
        root.right = BuildTree(rightPreOrder, rightInOrder);
        return root;
    }
}
