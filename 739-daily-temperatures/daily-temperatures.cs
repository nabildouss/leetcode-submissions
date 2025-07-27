public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Length;
        var results = new int[n];
        var stack = new Stack<int>();
        
        for(int i = n-1; i >= 0; i--) {
            while(stack.Count() > 0 && temperatures[stack.Peek()] <= temperatures[i]) {
                var pop = stack.Pop();
            }
            results[i] = stack.Count() == 0 ? 0 : stack.Peek() - i;
            stack.Push(i);
        }
        return results;

    }
}
