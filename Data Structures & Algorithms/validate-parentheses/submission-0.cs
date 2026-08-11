public class Solution {
    public bool IsValid(string s) {
        Stack<char> list = new Stack<char>();
        for (int i=0;i<s.Length;i++){
            if(s[i]=='['||s[i]=='{'||s[i]=='('){
                list.Push(s[i]);
            }
            else if(s[i]==']'||s[i]=='}'||s[i]==')'){
                if(list.Count<1){
                    return false;
                }
                else{
                char last=list.Pop();
                if(s[i]==']' && last!='['){
                    return  false;
                }
                else if(s[i]=='}' && last !='{'){
                    return false;
                }
                else if(s[i]==')' && last != '('){
                    return false;
                }
                }
            }
        }
        return list.Count==0;
    }
}
