public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        var n = s.Length;
        if (n == 0) return true;
        var first = 0;
        var last = n-1;
        while(first < last) {
            if (!IsAlphanumeric(s[first])) {
                first++;
                continue;
            }
            if (!IsAlphanumeric(s[last])) {
                last--;
                continue;
            }
            if (s[first] != s[last]) return false;
            first++;
            last--;
        }
        return true;
    }

    public bool IsAlphanumeric(char c) {
        return (c >=48 && c <= 57) || (c >= 97 && c <= 122);
    }
}