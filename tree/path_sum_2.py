# https://leetcode.com/problems/path-sum-ii/

# Definition for a  binary tree node
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    # @param root, a tree node
    # @param sum, an integer
    # @return a list of lists of integers
    def pathSum(self, root, mysum):
        pathlist = []
        stack = []
        
        if root != None:
            stack.append([root])
        
        while stack != []:
            curpath = stack.pop()
            tail = curpath[-1]
            
            if tail.left != None:
                path = curpath + [tail.left]
                stack.append(path)
            if tail.right != None:
                path = curpath + [tail.right]
                stack.append(path)
            if tail.left == None and tail.right == None:
                valpath = []
                for i in curpath:
                    valpath.append(i.val)
                if mysum == sum(valpath):
                    pathlist.append(valpath)
                
        return pathlist