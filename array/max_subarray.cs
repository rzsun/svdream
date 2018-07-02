// https://leetcode.com/problems/maximum-subarray/

public class Solution {
    // [2, -1, 2, -4, 7]
    // max = 2
    // currentSum = 1
    // start = 0
    // end = 2
    
    
    public int MaxSubArray(int[] nums) {
        if (nums == null || nums.Count() == 0) {
            return int.MinValue;
        }
        
        int max = nums[0];
        int currentSum = nums[0];
        
        int start = 0;
        int end = 1;
        
        while (start < nums.Count() && end < nums.Count()) {
            if (currentSum < 0) {
                currentSum = nums[end];
                start = end;
            }
            else {
                currentSum += nums[end];
            }
            
            if (currentSum > max) {
                max = currentSum;
            }
            
            end++;
        }
        
        return max;
    }
}