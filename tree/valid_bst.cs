// https://leetcode.com/problems/validate-binary-search-tree/

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
    public bool IsValidBST(TreeNode root) {
        if (root == null) {
            return true;
        }
        
        bool leftValid = true;
        if (root.left != null) {
            leftValid = IsValidBST(root.left);
        }
        bool rightValid = true;
        if (root.right != null) {
            rightValid = IsValidBST(root.right);
        }
        
        int val = root.val;
        
        bool valid = true;
        
        if (root.left != null) {
            valid = valid && (MaxValue(root.left) < val);
        }
        
        if (root.right != null) {
            valid = valid && (MinValue(root.right) > val);
        }
        
        return valid && leftValid && rightValid;
    }
    
    public int MinValue(TreeNode n) {
        int? leftMin = null;
        if (n.left != null) {
            leftMin = MinValue(n.left);
        }
        int? rightMin = null;
        if (n.right != null) {
            rightMin = MinValue(n.right);
        }
        int min = n.val;
        
        if (leftMin != null) {
            min = Math.Min(min, leftMin.Value);
        }
        if (rightMin != null) {
            min = Math.Min(min, rightMin.Value);
        }
        return min;
    }
    
    public int MaxValue(TreeNode n) {
        int? leftMax = null;
        if (n.left != null) {
            leftMax = MaxValue(n.left);
        }
        int? rightMax = null;
        if (n.right != null) {
            rightMax = MaxValue(n.right);
        }
        int max = n.val;
        
        if (leftMax != null) {
            max = Math.Max(max, leftMax.Value);
        }
        if (rightMax != null) {
            max = Math.Max(max, rightMax.Value);
        }
        return max;
    }
}