# https://leetcode.com/problems/balanced-binary-tree/description/

# Definition for a  binary tree node
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    # @param root, a tree node
    # @return a boolean
    def isBalanced(self, root):
        if self.isBalancedHeight(root, 0) == -1:
            return False
        else:
            return True
    
    def isBalancedHeight(self, root, height):
        if root == None:
            return height
        
        l = self.isBalancedHeight(root.left, height + 1)
        r = self.isBalancedHeight(root.right, height + 1)
        
        if abs(l - r) > 1:
            return -1
        if l == -1 or r == -1:
            return -1
        
        return max(l, r)