public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        Array.Sort(position, speed);
        Array.Reverse(position);
        Array.Reverse(speed);
        double[] time = new double[n];
        for (int i = 0; i < n; i++){
            time[i]=(double)(target-position[i])/speed[i];
        }
        Stack<double> list = new Stack<double>();
        for (int i = 0; i < n; i++){
            if(list.Count==0 || time[i]>list.Peek()){
                list.Push(time[i]);
            }
        }
        return list.Count;
        }
}
