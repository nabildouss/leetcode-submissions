public class Solution {
    public int MaxArea(int[] height) {
        var n = height.Length;
        var i = 0;
        var j = n - 1;
        var ans = -1;
        while(i < j) {
            var curr = (j - i) * Math.Min(height[i], height[j]);
            if (curr > ans) ans = curr;
            if (height[j] > height[i]) {
                i++;
            }
            else {
                j--;
            }
        }
        return ans;

    }
}