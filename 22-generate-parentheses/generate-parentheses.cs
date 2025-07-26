public class Solution { 
    public class Node {
        public string s;
        public int open = 0;
        public Node(string s, int open) {
            this.s = s;
            this.open = open;
        }
    }

    public List<string> GenerateParenthesis(int n) {
        List<Node> results = new List<Node>();
        var stack = new Stack<Node>();
        for(int i = 0; i < n; i++) {
            results = new List<Node>();
            if (stack.Count() == 0) stack.Push(new Node("", 0));
            var c = stack.Count();
            for(int j = 0; j < c; j++) {
                var pop = stack.Pop();
                var temp = pop.s + "(";
                var tempOpen = pop.open + 1;
                results.Add(new Node(temp, tempOpen));
                for (int k = 1; k <= tempOpen; k++) 
                {
                    temp = temp + ")";
                    results.Add(new Node(temp, tempOpen - k));
                }
            }
            foreach(var r in results) {
                stack.Push(r);
            }
        }
        var res = new List<string>();
        foreach(var r in results) {
            if(r.open == 0) res.Add(r.s);
        }
        return res;
    }
}
