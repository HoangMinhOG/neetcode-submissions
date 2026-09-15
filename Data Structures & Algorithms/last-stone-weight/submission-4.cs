public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach(int i in stones){
            queue.Enqueue(i,-i);
        }
        while(queue.Count>1){
            int x = queue.Dequeue();
            int y = queue.Dequeue();
            if(x!=y){
                int remaining = x-y;
                queue.Enqueue(remaining,-remaining);
            }
        }
        if(queue.Count==0){
            return 0;
        }
            return queue.Peek();
    }
}
