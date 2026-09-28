class Solution:
    def isValid(self, s: str) -> bool:
        closing = [')', '}', ']']
        opening = ['(', '{', '[']
        stack = []

        for i in s:
            if i in opening:
                stack.append(i)
            elif i in closing:
                if stack == []:
                    return False
                last = stack.pop()

                if i == ')' and last != '(':
                    return False
                elif i == '}' and last != '{':
                    return False
                elif i == ']' and last != '[':
                    return False

        if stack == []: return True

        return False
