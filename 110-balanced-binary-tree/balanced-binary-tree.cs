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
    public bool IsBalanced(TreeNode root) {
        var b = true;
        var res = DFS(root, ref b);
        return b;
    }

    public int DFS(TreeNode node, ref bool b) {

        if (node == null) return 0;
        var res = 0;
        var left = DFS(node.left, ref b);
        var right = DFS(node.right, ref b);
        b = b && (Math.Abs(right - left) <= 1);
        return Math.Max(right, left) + 1; 
    }
}