public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> Track = new Dictionary<int,int>();
        for(int i =0;i<nums.Length;i++ ){
            if(Track.ContainsKey(nums[i])){
                Track[nums[i]]++;
            }
            else{
                Track.Add(nums[i],1);
            }
            

        }
        var sortedDict = Track.OrderByDescending(x => x.Value)
                      .ToDictionary(x => x.Key, x => x.Value);

        foreach(KeyValuePair<int, int> kvp in sortedDict)
        {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        var enumerator = sortedDict.GetEnumerator();
       int [] solution = new int[k];
       for(int j = 0; j<k;j++){
            enumerator.MoveNext();
            var kvp = enumerator.Current;
            
            solution[j]=kvp.Key;
            
       }
       return solution;
    }
}
