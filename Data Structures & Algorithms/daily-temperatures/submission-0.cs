public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] array = new int[temperatures.Length];
        Stack<int> temp = new Stack<int>();
        for (int i=0;i<temperatures.Length;i++){
            while (temp.Count > 0 && temperatures[i]>temperatures[temp.Peek()]){
                int index=temp.Pop();
                array[index]=i-index;
            }
            temp.Push(i);
        }
        return array;
    }
}
