public class Solution {
    public int CalPoints(string[] operations) {
        List<int> stack = new List<int>();
        int totalVal=0;
        for (int i=0;i<operations.Length;i++){
            if(operations[i]=="C"){
                stack.RemoveAt(stack.Count-1);
            }
            else if(operations[i]=="D"){
                stack.Add(stack[stack.Count-1]*2);
            }
            else if(operations[i]=="+"){
                stack.Add(stack[stack.Count-2]+stack[stack.Count-1]);
            }
            else{
                stack.Add(int.Parse(operations[i]));
            }
        }
        for (int i=0;i<stack.Count;i++){
            totalVal+=stack[i];
        }
        return totalVal;
    }
}