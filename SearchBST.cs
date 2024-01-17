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

 // Between O(logn) & O(n) Computational Complexity
// 1/10/24

public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root == null)    // By putting null first, it allows you to not have to check root left and right to be null, saving comparisions.
        {
            return null;
        }
        else if(root.val == val)
        {
            return root;
        }
        else if(root.val > val)
        {
            return SearchBST(root.left, val);
        }
        else
        {
            return SearchBST(root.right, val);
        }
    }
}