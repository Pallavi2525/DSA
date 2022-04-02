public class MinStack {
    private Stack<KeyValuePair<int,int>> minStack;
    public MinStack() {
        minStack = new Stack<KeyValuePair<int,int>>();
    }
    
    public void Push(int val) {
        var currMin = val;
        if(minStack.Count > 0){
            currMin = Math.Min(currMin, GetMin());
        }
        minStack.Push(new KeyValuePair<int,int>(val,currMin));
    }
    
    public void Pop() {
        minStack.Pop();
    }
    
    public int Top() {
        return minStack.Peek().Key;
    }
    
    public int GetMin() {
        return minStack.Peek().Value;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */