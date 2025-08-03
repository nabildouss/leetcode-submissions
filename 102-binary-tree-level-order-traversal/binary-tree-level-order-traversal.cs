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
    
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        LevelOrder(root, 1, ref res);
        return res;
    }
    public void LevelOrder(TreeNode root, int level, ref IList<IList<int>> res) {
        if (root == null) return;
        if (res.Count < level) res.Add(new List<int>());
        res[level - 1].Add(root.val);
        LevelOrder(root.left, level + 1, ref res);
        LevelOrder(root.right, level + 1, ref res);
    }
}