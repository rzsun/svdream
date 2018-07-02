// https://leetcode.com/problems/longest-palindromic-substring/

public class Solution {
    public string LongestPalindrome(string s) {
        int len = s.Length;
        
        if (len < 1) {
            return null;
        }
        
        int start = 0;
        int max = 1;
        
        bool[,] arr = new bool[len, len];
        
        
        for (int i = 0; i < len; i++) {
            for (int j = 0; j <= i; j++) {
                if (s[i] == s[j] && (i - j <= 2 || arr[j + 1, i - 1])) {
                    arr[j, i] = true;
                }
                if (arr[j, i] && i - j + 1 > max) {
                    start = j;
                    max = i - j + 1;
                }
            }
        }
        
        return s.Substring(start, max);
    }
}