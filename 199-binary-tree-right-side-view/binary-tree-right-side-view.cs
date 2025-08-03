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
    public IList<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        if (root == null) return res;
        var right = RightSideView(root.right);
        var left = RightSideView(root.left);
        res.Add(root.val);
        res.AddRange(right);
        var rCount = right.Count;
        var lCount = left.Count;
        if (lCount > rCount) {
            for(int i = rCount; i < lCount; i++) {
                res.Add(left[i]);
            }
        }
        return (IList<int>)res;        
    }
}