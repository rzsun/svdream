// https://leetcode.com/problems/valid-parentheses/

public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        
        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') {
                st.Push(c);
            }
            
            if (st.Count == 0) {
                return false;
            }
            if (c == ')') {
                char top = st.Pop();
                if (top != '(') {
                    return false;
                }
            }
            if (c == ']') {
                char top = st.Pop();
                if (top != '[') {
                    return false;
                }
            }
            if (c == '}') {
                char top = st.Pop();
                if (top != '{') {
                    return false;
                }
            }
        }
        
        if (st.Count != 0) {
            return false;
        }
        return true;
    }
}