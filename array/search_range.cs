// https://leetcode.com/problems/search-for-a-range/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums == null || nums.Count() == 0) {
            return new int[] {-1, -1};
        }
        int start = FindStart(nums, target, 0, nums.Count() -1);
        int end = FindEnd(nums, target, 0, nums.Count() -1);
        return new int[] {start, end};
    }
    
    public int FindStart(int[] nums, int target, int start, int end) {
        if (start >= end) {
            if (nums[start] == target) {
                return start;
            }
            else {
                return -1;
            }
        }
        
        int mid = (start + end) / 2;
        int num = nums[mid];
        
        if (num >= target) {
            return FindStart(nums, target, start, mid);
        }
        else {
            return FindStart(nums, target, mid + 1, end);
        }
    }
    
    public int FindEnd(int[] nums, int target, int start, int end) {
        if (start == end) {
            if (nums[start] == target) {
                return start;
            }
            else {
                return -1;
            }
        }
        
        if (start + 1 == end) {
            if (nums[end] == target) {
                return end;
            }
            else if (nums[start] == target) {
                return start;
            }
            else {
                return -1;
            }
        }
        
        int mid = (start + end) / 2;
        int num = nums[mid];
        
        if (num <= target) {
            return FindEnd(nums, target, mid, end);
        }
        else {
            return FindEnd(nums, target, start, mid - 1);
        }
    }
}