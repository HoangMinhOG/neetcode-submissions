public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        foreach(int i in nums){
            if(count.ContainsKey(i)){
                return true;
            }
            count.Add(i,1);
        }
        return false;
    }
}