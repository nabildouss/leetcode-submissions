public class MinStack {
    Stack<long> stack = new Stack<long>();
    long min = Int32.MaxValue;
    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(stack.Count == 0) {
            min = val;
            stack.Push(0);
        }
        else {
            stack.Push(val - min);
            if(val < min) min = val;
        }
    }
    
    public void Pop() {
        if(stack.Count() == 0) return;
        long pop = stack.Pop();
        if(pop < 0) {
            min = min - pop;
        }
    }
    
    public int Top() {
        long top = stack.Peek();
        if (top > 0) return (int) (top + min);
        return (int)min;
    }
    
    public int GetMin() {
        return (int)min;
    }
}
