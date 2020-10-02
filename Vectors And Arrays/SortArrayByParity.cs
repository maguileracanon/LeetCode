public class Solution {
    public int[] SortArrayByParity(int[] A) {
        int j=0;
        int temp;
        for(int i=0;i<A.Length;i++){
            if (A[j]%2 == 0){
                j++;
            }
            else{
                temp=A[j];
                for (int k=j;k<A.Length-1;k++){
                 A[k]=A[k+1];   
                }
                A[A.Length-1]=temp;
            }
        }
        return A;
    }
}