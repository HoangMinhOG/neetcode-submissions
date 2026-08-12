public class MinStack {
        private Stack<int> minStack;
        private Stack<int> stack ;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count >0){
            minStack.Push(Math.Min(val,minStack.Peek()));
        }
        else{
            minStack.Push(val);
        }

    }
    
    public void Pop() {
        minStack.Pop();
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
