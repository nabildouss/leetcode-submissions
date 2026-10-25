public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            var left = target - nums[i];
            if(dic.ContainsKey(left)) {
                return [dic[left], i];
            }
            dic[nums[i]] = i;
        }
        return [-1, -1];

    }
}