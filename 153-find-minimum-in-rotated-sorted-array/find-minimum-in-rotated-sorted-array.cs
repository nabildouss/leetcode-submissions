public class Solution {
    public int FindMin(int[] nums) {
        var min = 0;
        var max = nums.Length - 1;
        var res = nums[0];
        while(min <= max) {
            var mid = (max + min) /2;
            if(nums[mid] <= res) {
                res = nums[mid];
            }
            if(nums[max] >= nums[mid]) {
                max = mid - 1;
            }
            else min = mid + 1;            
        }
        return res;
    }
}
