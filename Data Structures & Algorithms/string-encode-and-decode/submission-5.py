class Solution:

    def encode(self, strs: List[str]) -> str:
        encoded_strings =[""]
        for s in strs:
            sl = str(len(s))
            sl +='#'
            encoded_strings.append(sl)
            encoded_strings.append(s)
        return "".join(encoded_strings)

    def decode(self, s: str) -> List[str]:
        res=[]
        i = 0

        while i <len(s):
            j =i
            while s[j]!='#':
                j+=1
            length = int(s[i:j])
            i=j+1
            j=i+length
            res.append(s[i:j])
            i=j
        
        return res