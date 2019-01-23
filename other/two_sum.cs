// https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, List<int>> numToIndex = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!numToIndex.ContainsKey(nums[i]))
            {
                numToIndex[nums[i]] = new List<int>();
            }
            numToIndex[nums[i]].Add(i);    
        }
        foreach (KeyValuePair<int, List<int>> entry in numToIndex)
        {
            int difference = target - entry.Key;
            if (numToIndex.ContainsKey(difference))
            {
                foreach (int i in numToIndex[difference])
                {
                    if (i != entry.Value[0])
                    {
                        return new int[2] {entry.Value[0], i}; 
                    }
                }
            }
        }
        return new int[0];
    }
}