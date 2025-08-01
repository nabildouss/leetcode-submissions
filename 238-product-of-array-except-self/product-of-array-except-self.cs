public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;
        var ans = new int[nums.Length];
        Array.Fill(ans, 1);
        int curr = 1;
        for(int i = 0; i < n; i++) {
            ans[i] *= curr;
            curr *= nums[i];
        }
        curr = 1;
        for(int i = n - 1; i >= 0; i--) {
            ans[i] *= curr;
            curr *= nums[i];
        }
        return ans;
    }
}