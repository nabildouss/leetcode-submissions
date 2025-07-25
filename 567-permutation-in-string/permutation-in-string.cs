public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        var dict = new Dictionary<char, int>();
        foreach(var c in s1) {
            if(dict.Keys.Contains(c)) dict[c]++;
            else dict[c] = 1;
        }
        var dict2 = new Dictionary<char, int>(dict);
        var i = 0;
        var j = 0;
        while (i < s2.Length && j < s2.Length){
            var c = s2[j];
            if(!dict.Keys.Contains(c) || !dict2.Keys.Contains(c)) {
                dict2 = new Dictionary<char, int>(dict);
                i++;
                j = i;
            }
            else {
                dict2[c]--;
                j++;
                if(dict2[c] == 0) dict2.Remove(c);
                if(dict2.Keys.Count() == 0) return true;
            }
        }
        return false;
    }
}