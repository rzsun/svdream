# https://leetcode.com/problems/populating-next-right-pointers-in-each-node/description/

# Definition for binary tree with next pointer.
# class TreeLinkNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None
#         self.next = None

class Solution:
    # @param root, a tree link node
    # @return nothing
    def connect(self, root):
        if not root:
            return
        
        curLev = [root]
        nextLev = []

        i = 0
        
        while len(curLev) > 0:
            if i < len(curLev):
                curNode = curLev[i]
                curNode.next = None
            
                if i < len(curLev) - 1:
                    curNode.next = curLev[i + 1]
                
                if curNode.left:
                    nextLev.append(curNode.left)
                if curNode.right:
                    nextLev.append(curNode.right)

                i += 1
            else:
                curLev = nextLev
                nextLev = []
                i = 0
