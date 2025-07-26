public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        var freqs1 = new int[26];
        var freqs2 = new int[26];

        foreach(var c in s1) {
            freqs1[c - 'a']++;
        }
        var i = 0;
        var j = 0;
        while ( j < s2.Length && j - i + 1 < s1.Length ){
            freqs2[s2[j] - 'a']++;
            j++;
        }
        while (j < s2.Length) {
            freqs2[s2[j]-'a']++;
            if(AreEqual(freqs1, freqs2)) return true;
            freqs2[s2[i] - 'a']--;
            i++;
            j++;
        }
        return false;
    }

    public bool AreEqual(int[] a, int[] b) {
        for(int i=0; i < 26; i++) {
            if(a[i] != b[i]) return false;
        }
        return true;
    }
}