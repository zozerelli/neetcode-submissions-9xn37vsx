public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //the dictionary or hashmap is our key and our value is list
        var res = new Dictionary<string,List<string>>();
        //for each word in the array string
        foreach (var s in strs){
            int[]count=new int[26];//intializing an interger array of 26 because there are 26 letters
          string lowerS = s.ToLower();// make all characters lower case
            foreach(char c in lowerS){
                count[c-'a']++;//add 1 to the position for the characted - 'a' bc of ASCII offset
            }
            string key = string.Join(",",count);
            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
