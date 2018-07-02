# https://leetcode.com/problems/add-two-numbers/

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    # @return a ListNode
    def addTwoNumbers(self, l1, l2):
        head = curnode = None
        carry = 0
        
        while (l1 != None or l2 != None) or carry == 1:
            sum = carry
            carry = 0
            
            if l1 != None:
                sum += l1.val
            if l2 != None:
                sum += l2.val
            
            if sum >= 10:
                carry = 1
                sum -= 10
            
            if head == None:
                head = curnode = ListNode(sum)
            else:
                newnode = curnode.next = ListNode(sum)
                curnode = newnode
            
            if head == None:
                head = curnode
            
            if l1 != None:
                l1 = l1.next
            if l2 != None:
                l2 = l2.next
            
            
        curnode.next = None
        return head