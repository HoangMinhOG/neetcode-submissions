public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char,int> first = new Dictionary<char,int>();
        Dictionary<char,int> second = new Dictionary<char,int>();
        foreach(char c in s){
            if(first.ContainsKey(c)){
                first[c]++;
            }
            else{
                first[c]=1;;
            }
        }
        foreach(char c in t){
            if(second.ContainsKey(c)){
                second[c]++;
            }
            else{
                second[c]=1;
            }
        }
        foreach(char c in s){
            if(!second.ContainsKey(c)||first[c]!=second[c]){
                return false;
            }
        }
        return true;
    }
}
