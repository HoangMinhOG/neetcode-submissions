public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int L = 1, H = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            H = Math.Max(H, piles[i]);
        } 
        int answer=0; 
            while(L<=H){
                int k  = (L+H)/2;
                int sum=0;
                for (int i=0;i<piles.Length;i++){
                    sum+=(int)Math.Ceiling(piles[i]/(double)k);
                }
                if(sum<=h){
                    H=k-1;
                    answer=k;
                }
                else{
                    L=k+1;
                }
            }
            return answer;
        }
    }
   

