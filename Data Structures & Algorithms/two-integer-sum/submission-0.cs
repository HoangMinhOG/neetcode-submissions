public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> sum = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int compliment = target - nums[i];
            if(sum.ContainsKey(compliment)){
                    return new int[] {sum[compliment],i};
            }
            else{
            sum[nums[i]]=i;
            }
        }
        return new int[0];
    }
}
