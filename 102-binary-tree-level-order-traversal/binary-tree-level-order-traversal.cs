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
    public Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
    
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        LevelOrder(root, 1);
        int i = 1;
        while(d.ContainsKey(i)) {
            res.Add(d[i]);
            i++;
        }
        return res;
    }
    public void LevelOrder(TreeNode root, int level) {
        if (root == null) return;
        if (!d.ContainsKey(level)) d[level] = new List<int>();
        d[level].Add(root.val);
        LevelOrder(root.left, level + 1);
        LevelOrder(root.right, level + 1);
    }
}