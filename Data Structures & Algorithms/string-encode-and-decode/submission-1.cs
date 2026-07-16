public class Solution {

    public string Encode(IList<string> strs) {
        string final = "";
        foreach (string str in strs)
        {
            final += str.Length + "#" + str;
        }
        return final;
    }

    public List<string> Decode(string s) {
      //making a new list to store the decoded strings
    List<string> result = new List<string>();

    //iterating through the string to decode it it should start with a number followed by a # and then the string

    for (int i = 0; i < s.Length;)
    {
        int j = i + 1;

        if (j < s.Length && IsNumber(s[i]))
        {
            //if it is 3 digit number
            if (i + 3 < s.Length &&
                IsNumber(s[i]) &&
                IsNumber(s[j]) &&
                IsNumber(s[j + 1]) &&
                s[i + 3] == '#')
            {
                string lengthStr = "";
                lengthStr += s[i];
                lengthStr += s[i + 1];
                lengthStr += s[j + 1];

                int length = int.Parse(lengthStr);
                string str = s.Substring(i + 4, length);
                result.Add(str);

                i += length + 4;
            }
            //if it is 2 digit
            else if (i + 2 < s.Length &&
                     IsNumber(s[i]) &&
                     IsNumber(s[j]) &&
                     s[i + 2] == '#')
            {
                string lengthStr = "";
                lengthStr += s[i];
                lengthStr += s[i + 1];

                int length = int.Parse(lengthStr);
                string str = s.Substring(j + 2, length);
                result.Add(str);

                i += length + 3;
            }
            else
            {
                string lengthStr = "";
                lengthStr += s[i];

                int length = int.Parse(lengthStr);
                string str = s.Substring(j + 1, length);
                result.Add(str);

                i += length + 2;
            }
        }
    }

    return result;
    }
    bool IsNumber(char c)
    {
        return c >= '0' && c <= '9';
    }
}
