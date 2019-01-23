class Solution:
    
    matched_strings = []

    def isMatch(self, s, p):
        """
        :type s: str
        :type p: str
        :rtype: bool
        """

        pattern_matches = []

        if p == '':
            return s == p

        for i in range(0, len(p)):
            print ("matching " + p[i])

            if i == 0:
                # star can match all prefixes
                if p[0] == '*':
                    prefixes = self.get_all_prefix(s, 0)
                    pattern_matches.append(prefixes)
                
                elif len(s) == 0:
                    return False
                    
                elif p[0] == '?' or p[0] == s[0]:
                    match_set = set()
                    match_set.add(s[0])
                    pattern_matches.append(match_set)

                else:
                    return False
                    
            else:
                prev_matches = pattern_matches[i - 1]

                new_prefixes = set()
                for match in prev_matches:

                    if p[i] == '*':
                        prefixes = self.get_all_prefix(s, len(match))
                        
                        for prefix in prefixes:
                            new_prefixes.add(match + prefix)
                    
                    elif len(match) < len(s):
                        if p[i] == '?':
                            appended = match + s[len(match)]
                            new_prefixes.add(appended)
                        else:
                            appended = match + p[i]
                            if appended == s[0:len(appended)]:
                                new_prefixes.add(appended)
                
                pattern_matches.append(new_prefixes)

        if pattern_matches:
            for match in pattern_matches[-1]:
                if match == s:
                    return True


        return False


    def get_all_prefix(self, s, start_index):
        prefixes = set()
        length = len(s)

        for j in range(start_index, length + 1):
            prefixes.add(s[start_index:j])
        
        return prefixes
