// https://leetcode.com/problems/trapping-rain-water/

public class Solution {
    public int Trap(int[] height) {
        int start = 0;
        int end = height.Count() - 1;
        int leftMax = 0;
        int rightMax = 0;
        int total = 0;
        
        while (start <= end) {
            leftMax = Math.Max(height[start], leftMax);
            rightMax = Math.Max(height[end], rightMax);
            
            if (leftMax < rightMax) {
                total += leftMax - height[start];
                start++;
            }
            else {
                total += rightMax - height[end];
                end--;
            }
        }
        
        return total;
    }
}