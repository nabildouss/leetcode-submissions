public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>();
        foreach(var s in stones) {
            pq.Enqueue(s, -s);
        }
        while(pq.Count > 1) {
            var x = pq.Dequeue();
            var y = pq.Dequeue();
            if (x > y) pq.Enqueue(x - y, y - x);
        }

        return pq.Count == 0 ? 0 : pq.Dequeue();        
    }
}