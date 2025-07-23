public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length - 1;
        while (start < end) {
            var sum = numbers[start] + numbers[end];
            if (sum == target) return [start + 1, end + 1];
            if (sum > target) end --;
            else start ++;
        }

        return [];
    }
}