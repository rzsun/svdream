// https://leetcode.com/problems/count-and-say/

public class Solution {
    public string CountAndSay(int n) {
        string current = "1";
        
        while (n > 1) {
            string newStr = "";
            string currDigit = null;
            int currNum = 0;
            
            for(int i = 0; i < current.Length; i++) {
                if (currDigit == null) {
                    currDigit = current[i].ToString();
                    currNum++;
                }
                else if (currDigit != current[i].ToString()) {
                    newStr += currNum.ToString() + currDigit;
                    currNum = 1;
                    currDigit = current[i].ToString();
                }
                else {
                    currNum += 1;
                }
            }
            
            if (currDigit != null) {
                newStr += currNum.ToString() + currDigit;
            }
            current = newStr;
            n--;
        }
        return current;
    }
}