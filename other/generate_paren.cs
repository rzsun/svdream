// https://leetcode.com/problems/generate-parentheses/description/

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        return RecursiveGenerateParenthesis(n, n, "");
    }
    
    public List<string> RecursiveGenerateParenthesis(int left, int right, string current) {
        List<string> result = new List<string>();
        if (left == 0 && right == 0) {
            return new List<string>() { current };
        }
        
        if (left <= right && left > 0) {
            result.AddRange(RecursiveGenerateParenthesis(left - 1, right, current + "("));
        }
		if (right > 0) {
        	result.AddRange(RecursiveGenerateParenthesis(left , right - 1, current + ")"));
		}
        
        return result;
    }
}