public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k=0, count=1, store=0;
        for(int i=0; i<nums.Length-count+1;i++){
            if(nums[i]==val){
                nums[i]=nums[nums.Length-count];
                i--;
                count++;
            }
            else {
                k++;
            }
        }
        return k;
    }
}