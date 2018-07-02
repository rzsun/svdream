// https://leetcode.com/problems/zigzag-conversion/

public class Solution {
    public string Convert(string s, int numRows) {
        
        int length = s.Length;
        int diagLength = numRows + numRows - 2;
        
        string result = "";
        
        if (s.Length == 0) {
            return "";
        }
        if (s.Length == 1) {
            return s;
        }
        
        if (diagLength < 2) {
            return s;
        }
        
        
        for (int i = 0; i < numRows; i++) {
            if (i == 0 || i == numRows - 1) {
                for (int j = i; j < s.Length; j += diagLength) {
                    result += s[j];
                }
            }
            else {
                for (int j = i; j < s.Length; j += diagLength) {
                    result += s[j];
                    int opposite = j - i + diagLength - i;
                    if (opposite  < length) {
                        result += s[opposite];
                    }
                }
            }
        }
        return result;
    }
}