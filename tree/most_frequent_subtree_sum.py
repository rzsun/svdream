# https://leetcode.com/problems/most-frequent-subtree-sum/description/

# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution(object):
    def findFrequentTreeSum(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        sum, arr = self.findAllSums(root, [])

        freq = {}
        maxFreq = 0
        for x in arr:
            if x in freq:
                freq[x] += 1
            else:
                freq[x] = 1
            maxFreq = max(maxFreq, freq[x])
        
        res = []
        for x in freq:
            if freq[x] == maxFreq:
                res.append(x)
        
        return res
    
    def findAllSums(self, root, arr):
        if root == None:
            return (0, arr)
        
        sum = root.val + self.findAllSums(root.left, arr)[0] + self.findAllSums(root.right, arr)[0]
        arr.append(sum)
        
        return (sum, arr)