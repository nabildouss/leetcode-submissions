public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1) return s.Length;
        var ans = 0;
        var curr = 0;
        var begin = -1;
        var dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(dict.ContainsKey(s[i]) && dict[s[i]] >= begin){
                begin = dict[s[i]];
            }
            curr = i - begin;
            if (curr > ans) ans = curr;
            dict[s[i]] = i;
        }
        return ans;
    }
}