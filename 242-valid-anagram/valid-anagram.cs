public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var dict = new Dictionary<char, int>();
        foreach(var c in s) {
            if(dict.ContainsKey(c)) dict[c]++;
            else dict[c] = 1;
        }
        foreach(var c in t) {
            if(!dict.ContainsKey(c) || dict[c] <= 0) return false;
            dict[c]--;
        }
        return true;

    }
}