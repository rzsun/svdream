// https://leetcode.com/problems/container-with-most-water/description/

public class Solution {
    public int MaxArea(int[] height) {
        int pointerA = 0;
        int pointerB = height.Count() - 1;
        
        int maxArea = 0;
        
        while (pointerA < pointerB) {
            int currentArea = (pointerB - pointerA ) * Math.Min(height[pointerA], height[pointerB]);
            if (currentArea > maxArea) {
                maxArea = currentArea;
            }
            
            if (height[pointerA] < height[pointerB]) {
                pointerA++;
            }
            else {
                pointerB--;
            }
        }
        return maxArea;
    }
}