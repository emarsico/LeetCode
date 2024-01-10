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

 // Top 88.15% Runtime
//  1/7/9

public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null || root.val == null)
        {
            return 0;
        }

        return 1 + DepthRecurse(root);
    }

    public int DepthRecurse(TreeNode root)
    {   
        if(root.right != null && root.left != null)
        {
            int leftVal = DepthRecurse(root.left) + 1;
            int rightVal = DepthRecurse(root.right) + 1;
            
            if(rightVal >= leftVal)
            {
                return rightVal;
            }
            
            return leftVal;
        }
        else if(root.right != null)
        {
            return DepthRecurse(root.right) + 1;
        }
        else if(root.left != null)
        {
            return DepthRecurse(root.left) + 1;
        }

        return 0;
    }
}