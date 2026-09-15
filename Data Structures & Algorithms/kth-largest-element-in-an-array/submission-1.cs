public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach(int i in nums){
            queue.Enqueue(i,i);
        }
        while(queue.Count>k){
            queue.Dequeue();
        }
        return queue.Peek();
    }
}
