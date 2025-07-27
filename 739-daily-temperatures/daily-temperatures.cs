public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Length;
        if (n == 0) return new int[0];
        
        var results = new int[n];
        var stack = new Stack<int>();
        stack.Push(n-1);
        results[n-1] = 0;
        
        for(int i = n-2; i >= 0; i--) {
            var current = stack.Count();
            while(stack.Count() > 0 && temperatures[stack.Peek()] <= temperatures[i]) {
                var pop = stack.Pop();
            }
            results[i] = stack.Count() == 0 ? 0 : stack.Peek() - i;
            stack.Push(i);
        }
        return results;

    }
}
