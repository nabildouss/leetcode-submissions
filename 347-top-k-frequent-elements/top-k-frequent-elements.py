class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq = {}
        heap = []
        for i in nums:
            prev = freq.get(i, 0)
            freq[i] = prev + 1
        for i in freq.keys():
            heapq.heappush(heap, (freq[i], i))
            if len(heap) > k:
                heapq.heappop(heap)
        res = []
        for i in range(k):
            res.append(heapq.heappop(heap)[1])
        return res
        