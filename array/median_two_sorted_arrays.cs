// https://leetcode.com/problems/median-of-two-sorted-arrays/

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> combinedArray = new List<int>();
        int counter1 = 0;
        int counter2 = 0;
        
        while (counter1 < nums1.Count() && counter2 < nums2.Count()) {
            if (nums1[counter1] < nums2[counter2]) {
                combinedArray.Add(nums1[counter1]);
                counter1++;
            }
            else {
                combinedArray.Add(nums2[counter2]);
                counter2++;
            }
        }
        
        if (counter1 < nums1.Count()) {
            for (; counter1 < nums1.Count(); counter1++) {
                combinedArray.Add(nums1[counter1]);
            }
        }
        
        if (counter2 < nums2.Count()) {
            for (; counter2 < nums2.Count(); counter2++) {
                combinedArray.Add(nums2[counter2]);
            }
        }
        
        if (combinedArray.Count == 1) {
            return combinedArray[0];
        }
        
        if (combinedArray.Count % 2 == 0) {
            return (combinedArray[combinedArray.Count / 2] + combinedArray[combinedArray.Count / 2 - 1]) / 2.0;
        }
        else {
            return combinedArray[combinedArray.Count / 2];
        }
    }
}