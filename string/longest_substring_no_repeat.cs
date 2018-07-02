// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        int max = 0;
        int j = 0;
        for (int i = 0; i < s.Length; i++) {
            if (map.ContainsKey(s[i])) {
                j = Math.Max(j, map[s[i]] + 1);
            }
            map[s[i]] = i;
            
            max = Math.Max(max, i - j+1);
        }
        return max;
    }
}