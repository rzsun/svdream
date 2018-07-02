# https://leetcode.com/submissions/detail/17403124/

class Solution:
    # @return a string
    def longestCommonPrefix(self, strs):
        if strs == []:
            return ""
        
        s = ""
        i = 0
        while i < len(strs[0]):
            c = strs[0][i]
            for a in strs:
                if i >= len(a):
                    return s
                if c != a[i]:
                    return s
            i += 1
            s += c
        return s
