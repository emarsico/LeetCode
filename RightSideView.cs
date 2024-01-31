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


 // O(n) Computational Complexity
// 1/30/24


public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        if(root == null){return new List<int>();}

        List<int> tree = new List<int>();
        BreathOfTree(tree, root, 0);

        return tree;
    }

    public void BreathOfTree(List<int> tree, TreeNode branch, int depth)
    {
        if(branch == null){ return; }

        if(depth >= tree.Count)
        {
            tree.Add(branch.val);
        }

        if(branch.right != null)
        {
            BreathOfTree(tree, branch.right, depth+1);
        }

        if(branch.left != null)
        {
            BreathOfTree(tree, branch.left, depth+1);
        }

        return;
    }
}