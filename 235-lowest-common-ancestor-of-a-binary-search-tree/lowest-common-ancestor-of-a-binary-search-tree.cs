/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        while (root != null) {
            if ((long)(p.val - root.val) * (long)(q.val - root.val) <= 0) return root;
            if (p.val > root.val && q.val > root.val) root = root.right;
            else root = root.left;
        }
        return null;  
    }
}