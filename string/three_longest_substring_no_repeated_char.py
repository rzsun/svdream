def longestSubstr(s, ignore):
    start, end = 0,0
    max_start, max_end, max_len = 0, 0, 0
    chars = set()

    while end < len(s) and start < len(s):
        if s[end] in chars:
            while s[end] in chars:
                chars.remove(s[start])
                start += 1
        
        chars.add(s[end])
        end += 1

        curr_len = end - start
        if curr_len > max_len and (start, end) not in ignore:
            max_start = start
            max_end = end
            max_len = curr_len
    
    return max_start, max_end


def threeLongestSubstr(s):
    uniqe_res = set()

    longests = set()
    for i in range(0, 3):
        start, end = longestSubstr(s, longests)
        longests.add((start, end))
        uniqe_res.add((start, end))
        
    reverse_longests = set()
    for i in range(0, 3):
        start, end = longestSubstr(s[::-1], reverse_longests)
        reverse_longests.add((start, end))
        uniqe_res.add((len(s) - end, len(s) - start))
    
    longests_len = []
    for (start, end) in uniqe_res:
        longests_len.append(abs(start - end))
    
    longests_len.sort()
    longests_len.reverse()
    return longests_len[0:3]



def threeLongestSubstrBruteForce(s):
    substrings = [s[i: j] for i in range(len(s)) for j in range(i + 1, len(s) + 1)]
    lengths = []
    for s in substrings:
        if len(set(s)) == len(s):
            lengths.append(len(s))

    lengths.sort()
    lengths.reverse()
    return lengths[0:3]
