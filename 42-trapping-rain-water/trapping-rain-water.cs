public class Solution {
    public int Trap(int[] height) {
         var n = height.Length;
        var res = 0;
        var prevInd = 0;

        for(int i = 1; i < n; i++) {
            if(height[i] >= height[prevInd]) {
                prevInd = i;
            }
            else break;
        }

        var lastInd = n - 1;
        for(int i = n-2; i > 0; i--) {
            if(height[i] >= height[lastInd]) {
                lastInd = i;
            }
            else break;
        }
        
        var k = prevInd + 1;
        var j = lastInd -1;

        while(prevInd < lastInd) {
            if(height[k] >= height[prevInd]) {
                res += Filled(height, prevInd, k);
                prevInd = k;
                k++;
            }
            else if(height[j] >= height[lastInd]) {
                res += Filled(height, j, lastInd);
                lastInd = j;
                j--;
            }
            else {
                k++;
                j--;
            }
            
        }
        return res;

    }

    public int Filled(int[] height, int i, int j) {
        var min = Math.Min(height[i], height[j]);
        var res = (j - i - 1) * min;
        for (int k = i+1; k < j; k++) {
            res -= Math.Min(height[k], min);
        }
        return res;
    }
}