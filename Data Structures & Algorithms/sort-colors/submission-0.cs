public class Solution {
    public void SortColors(int[] nums) {
        int[] counts = [0,0,0];
        for(int j=0; j<nums.Length;j++){
            counts[nums[j]]+=1;
        }
        int i =0;
        for(int n=0;n<counts.Length;n++){
            for(int m=0;m<counts[n];m++){
                nums[i]=n;
                i++;
            }
        }
    }
}