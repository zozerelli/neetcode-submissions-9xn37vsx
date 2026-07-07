public class Solution {
    public bool IsPalindrome(string s) {
        /*this one will demonstrate using 2 pointers we want to ignore all character that are not alpha numerical
        in order to check I will not be using a built in function rather I will be using ASCII numbers 
        */

        int l=0;
        int r=s.Length-1;
        while(l<r){
            while(l<r&&!checkAlphaNum(s[l])){
                l++;
            }
            while(r>l &&!checkAlphaNum(s[r])){
                r--;
            }
            if(char.ToLower(s[l])!=char.ToLower(s[r])){
                return false;
            }
            r--;
            l++;
        }
        return true;

    }
    public bool checkAlphaNum(char c){
        return(c>='0'&& c<='9'||c>='A'&&c<='Z'||c>='a'&&c<='z' );
    }
}
