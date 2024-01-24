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
// 1/24/24

public class Solution {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> tree1 = new List<int>();
        List<int> tree2 = new List<int>();

        DFSLeaf(root1, tree1);
        DFSLeaf(root2, tree2);

        return tree1.SequenceEqual(tree2);
    }

    public void DFSLeaf(TreeNode node, List<int> tree)
    {
        if(node.left != null && node.right != null)
        {
            DFSLeaf(node.left, tree);
            DFSLeaf(node.right, tree);
            return;
        }
        else if(node.left != null)
        {
            DFSLeaf(node.left, tree);
            return;
        }
        else if(node.right != null)
        {
            DFSLeaf(node.right, tree);
            return;
        }

        tree.Add(node.val);
    }
}