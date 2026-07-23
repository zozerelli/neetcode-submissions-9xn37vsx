class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        #hash map key if we have tea the key would be 1t 1e 1a 
        #value will be string that have that pattern of count
        #time complexity O(m*n*26)m= is total input strings given and n=avg len of str
        #count array with [a->z]
        res = defaultdict(list) #mapping the charcter count of each string 
        for s in strs:
            count =[0]*26 #a...z
            for c in s:
                count[ord(c)-ord("a")]+=1
            res[tuple(count)].append(s)    
        return list(res.values())