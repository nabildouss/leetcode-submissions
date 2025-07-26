public class Solution {
    public int EvalRPN(string[] tokens) {
        var operationTokens = new string[] {"+", "-", "*", "/"};
        var stack = new Stack<int>();
        for(int i = 0; i < tokens.Length; i++) {
            if (operationTokens.Contains(tokens[i])) {
                var first = stack.Pop();
                var second = stack.Pop();
                int result = tokens[i] switch
                {
                    "+" => first + second,
                    "-" => second - first,
                    "*" => first * second,
                    _   => second / first
                };
                stack.Push(result);
            }else {
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }
}