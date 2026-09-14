public class KthLargest {
    PriorityQueue<int, int> queue = new PriorityQueue<int,int>();
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k=k;
        for(int i=0;i<nums.Length;i++){
            queue.Enqueue(nums[i],nums[i]);
        }
        while(queue.Count>k){
            queue.Dequeue();
        }
        
    }
    
    public int Add(int val) {
        queue.Enqueue(val,val);
        if(queue.Count>k){
            queue.Dequeue();
        }
        return queue.Peek();
    }
   
}
