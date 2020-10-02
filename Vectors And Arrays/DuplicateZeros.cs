public class Solution {
    public void DuplicateZeros(int[] arr) {
        int zeroCounter=0
        for (int i = 0; i < arr.Length; i++) 
            {
              if (arr[i]==0){
                zeroCounter++;
              }
        }
        int[] arrBigger = new int[zeroCounter];
        for (int i = 0; i < arr.Length; i++) {

            if (arr[i]==0){
                zeroCounter++;
              }
        }
    }
}