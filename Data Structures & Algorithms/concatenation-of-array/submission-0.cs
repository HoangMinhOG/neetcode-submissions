public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans =  new int[nums.Length*2];
        int n=nums.Length;
        for (int i=0;i<nums.Length;i++){
            ans[i]=nums[i];
            ans[i+n]=nums[i];
        }
        return ans;
    }
}