public class Solution {
    public int KthGrammar(int n, int k) {
        var elements = (1 << n-1);
        if (k > elements) return -1;
        var res = 1;
        while(elements > 0) {
            elements = elements >> 1;
            if (k > elements) {
                k = k - elements;
                res = 1 - res;
            }
        }
        return res;
    }
}