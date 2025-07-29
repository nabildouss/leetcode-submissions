public class Solution {
    public int Search(int[] nums, int target) {
        var min = 0;
        var max = nums.Length - 1;
        while(min <= max) {
            var mid = (max + min) /2;
            if(nums[mid] == target) {
                return mid;
            }
            if (target < nums[mid]) {
                if (nums[min] <= nums[mid] && target < nums[min]) min = mid + 1;
                else max = mid - 1;
            }
            else {
                if (nums[max] >= nums[mid] && nums[max] < target) max = mid - 1;
                else min = mid + 1;
            }            
        }
        return -1;   
    }
}
