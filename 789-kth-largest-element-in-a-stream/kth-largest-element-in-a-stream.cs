public class KthLargest {
    private PriorityQueue<int, int> p = new PriorityQueue<int, int>();
    private int k;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach(var n in nums) {
            p.Enqueue(n, n);
        }
        while (p.Count > k) {
            p.Dequeue();
        }
    }
    
    public int Add(int val) {
         p.Enqueue(val, val);
         if (p.Count > k) {
            p.Dequeue();
        }
        return p.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */