public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        points = QuickSort(points,0,points.Length-1);
        int[][] newArray = new int[k][];
        for(int i=0;i<k;i++){
            newArray[i]=points[i];
        }
        return newArray;

    }

        private int Dist(int[] point){
           return point[0]*point[0]+point[1]*point[1];
        }
        private int[][] QuickSort(int[][] arr, int s, int e){
            if(e-s+1<=1){
                return arr;
            }
            else{
                int[] pivot = arr[e];
                int left = s;
                for(int i=s;i<e;i++){
                    if(Dist(arr[i])<Dist(pivot)){
                        int[] tmp = arr[left];
                        arr[left]=arr[i];
                        arr[i]=tmp;
                        left+=1;
                    }
                }
                arr[e]=arr[left];
                arr[left]=pivot;
                QuickSort(arr,s,left-1);
                QuickSort(arr,left+1,e);
                return arr;
            }
        }
}
