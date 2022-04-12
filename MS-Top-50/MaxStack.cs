public class MaxStack {

    Stack<int> max, data;
    
    public MaxStack() {
        max = new Stack<int>();
        data = new Stack<int>();
    }
    
    public void Push(int x) {
        data.Push(x);
        int maxNum = x;
        if(max.Count != 0)
            maxNum = Math.Max(x, max.Peek());
        max.Push(maxNum);
    }
    
    public int Pop() {
        max.Pop();
        return data.Pop();
    }
    
    public int Top() {
        return data.Peek();
    }
    
    public int PeekMax() {
        return max.Peek();
    }
    
    public int PopMax() {
        int maxNum = max.Peek();
        Stack<int> buffer = new Stack<int>();
        while(data.Peek() != maxNum){
            buffer.Push(Pop());
        }
        Pop();
        while(buffer.Count != 0){
            Push(buffer.Pop());
        }
        return maxNum;
    }
}

/**
 * Your MaxStack object will be instantiated and called as such:
 * MaxStack obj = new MaxStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.PeekMax();
 * int param_5 = obj.PopMax();
 */