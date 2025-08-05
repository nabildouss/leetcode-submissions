public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], long>();
        foreach(var p in points) {
            var d = p[0]*p[0] + p[1]*p[1];
            pq.Enqueue(p, d);
        }
        var res = new int[k][];
        for(int i = 0; i < k; i++) {
            res[i] = pq.Dequeue();
        }
        return res;        
    }
}