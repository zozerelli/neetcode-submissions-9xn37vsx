class Solution:
     def twoSum(self, nums: List[int], target: int) -> List[int]:
        #take a hash map put the index as the value
        #subtract value from target
        #check if that key exists if not keep looping
        list_map ={}
        idx = 0
        for  i in nums:

            target_value=target-i

            if target_value in list_map:
                if list_map[target_value] ==idx:
                    idx += 1
                    list_map[i] = idx
                    continue
                ans = [list_map[target_value],idx]
                return ans
            list_map[i] = idx
            idx += 1
        return None




        