# https://leetcode.com/problems/string-to-integer-atoi/description/

INT_MIN = -2147483648
INT_MAX = 2147483647

class Solution(object):
    def myAtoi(self, str):
        """
        :type str: str
        :rtype: int
        """
        tally = None
        mult = 1
        
        while str:
            char = str[0]
            num = self.getNum(char)

            if tally == None:
                if num != None:
                    tally = num
                elif char == "-":
                    mult = -1
                    tally = 0
                elif char == "+":
                    tally = 0
                elif char != " ":
                    break
            else:
                if num != None:
                    tally *= 10
                    tally += num
                else:
                    break
            str = str[1:]
        
        if not tally:
            return 0
        return min(max(INT_MIN, mult * tally), INT_MAX)
    
    def getNum(self, char):
        if char =="0":
            return 0
        if char == "1":
            return 1
        if char == "2":
            return 2
        if char == "3":
            return 3
        if char == "4":
            return 4
        if char == "5":
            return 5
        if char == "6":
            return 6
        if char == "7":
            return 7
        if char == "8":
            return 8
        if char == "9":
            return 9
        return None
