public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> store = new Stack<int>();
        for(int i=0;i<tokens.Length;i++){
            if(tokens[i]=="+"){
                int val1 =store.Pop();
                int val2 =store.Pop();
                store.Push(val1+val2);
            }
            else if(tokens[i]=="-"){
                int val1 =store.Pop();
                int val2 =store.Pop();
                store.Push(val2-val1);
            }
            else if(tokens[i]=="*"){
                int val1 =store.Pop();
                int val2 =store.Pop();
                store.Push(val2*val1);
            }
            else if(tokens[i]=="/"){
                int val1 =store.Pop();
                int val2 =store.Pop();
                store.Push(val2/val1);
            }
            else{
                store.Push(int.Parse(tokens[i]));
            }
        }
        return store.Pop();
    }
}
