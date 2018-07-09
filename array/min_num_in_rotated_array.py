# https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/

class Solution(object):
    def findMin(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        if len(nums) == 1:
            return nums[0]
        if len(nums) == 2:
            return min(nums[0], nums[1])
        
        start = nums[0]
        mid = nums[len(nums)/2]
        end = nums[-1]
        
        maxNum = max(start, mid, end)
        
        if maxNum == end:
            return start
        
        if mid > start:
            return self.findMin(nums[len(nums)/2 + 1:len(nums)])
        else:
            return self.findMin(nums[0:len(nums)/2 + 1])
            
        