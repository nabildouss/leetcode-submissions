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
        if (root == null) return 0;
        return 1 + GoodNodes(root.left, root.val) + GoodNodes(root.right, root.val);

    }

    public int GoodNodes(TreeNode root, int max) {
        if (root == null) return 0;
        int res = root.val >= max ? 1 : 0;
        max = res * root.val + (1-res) * max;
        return res + GoodNodes(root.left,max) + GoodNodes(root.right, max);
    }
}