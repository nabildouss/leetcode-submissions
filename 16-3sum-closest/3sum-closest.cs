public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int closest = nums[0] + nums[1] + nums[2];
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++) {
            var left = i+1;
            var right = nums.Length - 1;
            while (left < right) {
                var currentSum = nums[left] + nums[right] + nums[i];
                if (Math.Abs(target - closest) > Math.Abs(target - currentSum)) {
                    closest = currentSum;
                }
                if (currentSum == target) return target;
                if (currentSum > target) {
                    right--;
                }
                else {
                    left++;
                }
            }
        }
        return closest;
    }
}