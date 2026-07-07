public class Solution {
        public bool IsPalindrome(string s) 
        {
            string cleanString="";
            foreach (char c in s)
            if (Char.IsLetterOrDigit(c)){
               
                cleanString+=c;
            }
            cleanString=cleanString.ToLower();
            string reversed = new( cleanString.Reverse().ToArray());
            if(cleanString.Equals(reversed)){
                return true;
            }
                return false;

    }
}
