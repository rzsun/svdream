class TrieNode:
    def __init__(self, char, current_string):
        self.char = char
        self.current_string = current_string
        self.is_terminal = False
        self.children = {}
    
    def get_or_add_child(self, child_char):
        if child_char not in self.children.keys():
            child = TrieNode(child_char, self.current_string + child_char)
            self.children[child_char] = child

        return self.children[child_char]

    def get_all_terminal(self):
        res = []

        stack = []
        stack.extend(self.children.values())
        
        while stack:
            curr = stack.pop()
            if curr.is_terminal:
                res.append(curr.current_string)
            stack.extend(curr.children.values())
        
        return res


class AutoComplete:
    def __init__(self):
        self.roots = {}

    def create_trie(self, corpus):
        for phrase in corpus:
            self.add_phrase(phrase)

    def add_phrase(self, phrase):
        if not phrase:
            return
        
        first_char = phrase[0]
        if first_char not in self.roots.keys():
            self.roots[first_char] = TrieNode(first_char, first_char)

        node = self.roots[first_char]
        for char in phrase[1:]:
            node = node.get_or_add_child(char)
        
        node.is_terminal = True

    def complete(self, input):
        if not input or input[0] not in self.roots.keys():
            return None
        
        node = self.roots[input[0]]
        for char in input[1:]:
            if char not in node.children.keys():
                return None
            node = node.children[char]
        
        return node.get_all_terminal()
