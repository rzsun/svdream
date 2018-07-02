# https://leetcode.com/problems/max-increase-to-keep-city-skyline/description/

class Solution(object):
    def maxIncreaseKeepingSkyline(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """
        if not grid or len(grid) == 0 or len(grid[0]) == 0:
            return None
        
        xLen = len(grid[0])
        yLen = len(grid)
        
        xMax = [0] * xLen
        
        for i in range(0, xLen):
            for j in range(0, yLen):
                xMax[i] = max(grid[j][i], xMax[i])
                
        yMax = [0] * yLen
        
        for j in range(0, yLen):
            for i in range(0, xLen):
                yMax[j] = max(grid[j][i], yMax[j])
                
        total = 0
        
        for i in range(0, xLen):
            for j in range(0, yLen):
                total += min(xMax[i], yMax[j]) - grid[i][j]
        
        return total