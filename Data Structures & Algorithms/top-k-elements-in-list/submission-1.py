class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        #Solution that is O(n) time and O(n) mem
        #bucket sort index will be the counts of each value and and the values part 
        #will have a list that shows which values have that particular count
        #will start at the top at the top end of the array
        count ={}
        freq=[[] for i in range(len(nums)+1)]

        for n in nums:
            count[n] = 1+ count.get(n,0)#this will return 0 if the number doesnt already exist
        for n, c in count.items():
            freq[c].append(n)
        
        res = []

        for i in range(len(freq)-1,0,-1):
            for n in freq[i]:
                res.append(n)
                if len(res)==k:
                    return res
