public class MyStack {
    private Queue<int> queue;
    private Queue<int> queue2;

    public MyStack() {
         queue = new Queue<int>();
         queue2 = new Queue<int>();
    }
    
    public void Push(int x) {
        queue2.Enqueue(x);
        while (queue.Count > 0)
        {
            queue2.Enqueue(queue.Dequeue());
        }

        Queue<int> temp = queue;
        queue = queue2;
        queue2 = temp;
    }
    
    public int Pop() {
       return queue.Dequeue();

    }
    
    public int Top() {
        return queue.Peek();
    }
    
    public bool Empty() {
        if(queue.Count==0){
            return true;
        }
        else{
            return false;
        }
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */