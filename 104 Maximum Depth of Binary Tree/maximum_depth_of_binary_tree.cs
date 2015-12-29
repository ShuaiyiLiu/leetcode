/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {	// Author: Xinyu Chen
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        return Math.Max(MaxDepth(root.left) + 1, MaxDepth(root.right) + 1);
    }
}