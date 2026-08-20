public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int L=0, R = matrix.Length*matrix[0].Length-1;
        int rows = matrix.Length, cols = matrix[0].Length;
        while (L<=R){
            int mid =(L+R)/2;
            int row = mid/cols, col = mid%cols;
            int value = matrix[row][col];
            if(target>value){
                L=mid+1;
            }
            else if(target<value){
                R=mid-1;
            }
            else{
                return true;
            }
        }
        return false;
    }
}
