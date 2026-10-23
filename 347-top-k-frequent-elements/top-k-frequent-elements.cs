public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();

        foreach(var num in nums) {
            if (!dic.ContainsKey(num)) {
                dic[num] = 1;
            }
            else {
                dic[num]++;
            }
        }

        var dic2 = new List<int>[nums.Length + 1];
        foreach(var entry in dic) {
            var freq = entry.Value;
            if(dic2[freq] == null) dic2[freq] = new List<int>();
            dic2[freq].Add(entry.Key);
        }
        var ans = new int[k];
        var current = 0;
        for(int i = nums.Length; i > -1; i--) {
            if(dic2[i] != null) {
                foreach(var n in dic2[i]) {
                    if(current == k) return ans;
                    ans[current] = n;
                    current++;
                }
            }
        }
        return ans;
    }
}