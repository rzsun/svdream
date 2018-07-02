// https://leetcode.com/problems/permutations/

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> list = new List<IList<int>>();
        PermuteRecursive(list, new List<int>(), new HashSet<int>(nums));
        
        return list;
    }
    
    public void PermuteRecursive(IList<IList<int>> total, List<int> current, HashSet<int> nums) {
        if (nums.Count() == 0) {
            total.Add(current);
        }
        else {
            foreach (int a in nums) {
                List<int> newCurrent = new List<int>(current);
                newCurrent.Add(a);
                HashSet<int> newNums = new HashSet<int>(nums);
                newNums.Remove(a);
                PermuteRecursive(total, newCurrent, newNums);
            }
        }
    }
}