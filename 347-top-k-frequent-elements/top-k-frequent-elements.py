class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq = {}
        count = [[] for i in range(len(nums) + 1)]
        for i in nums:
            prev = freq.get(i, 0)
            freq[i] = prev + 1
        for i in freq.keys():
            count[freq[i]].append(i)
        res = []
        for i in range(len(nums) + 1):
            for n in count[-i-1]:
                res.append(n)
                if len(res) == k:
                    return res
        return res
        