# https://leetcode.com/problems/majority-element/description/

class Solution:
    # @param num, a list of integers
    # @return an integer
    def majorityElement(self, num):
        freqmap = {}
        for i in num:
            if i in freqmap.keys():
                freqmap[i] += 1
            else:
                freqmap[i] = 1
        for k, v in freqmap.iteritems():
            if v >= len(num)/2.0:
                return k
        return None