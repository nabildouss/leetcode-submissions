public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var pair = new int[position.Length][];
        for(int i = 0; i < position.Length; i++) {
            pair[i] = new int[] {position[i], speed[i]};
        }
        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        var stack = new Stack<double>();
        foreach(var p in pair) {
            var timeNeeded = (double) (target - p[0]) / (double) p[1];
            stack.Push(timeNeeded);
            if (stack.Count() > 1 && stack.Peek() <= stack.ElementAt(1)) stack.Pop();
        }
        return stack.Count();
    }
}