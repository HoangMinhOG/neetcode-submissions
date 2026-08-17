public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> queue = new Queue<int>();
        for(int i=0;i<students.Length;i++){
            queue.Enqueue(students[i]);
        }
        int sandwichIndex = 0, attempt = 0;
        while(queue.Count>0){
            int student = queue.Peek();
            if(student==sandwiches[sandwichIndex]){
                queue.Dequeue();
                sandwichIndex++;
                attempt=0;
            }
            else{
                queue.Enqueue(student);
                queue.Dequeue();
                attempt++;
            }
            if (attempt==queue.Count){
                break;
            }
        }
        return queue.Count;
    }
}