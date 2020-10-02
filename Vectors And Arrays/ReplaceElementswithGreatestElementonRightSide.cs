public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int max=-1;
        int max_past;
        for (int i=arr.Length-1; i>=0; i--){
            max_past=max;
            if(arr[i]>max){
                max=arr[i];
            } 
            arr[i]=max_past;
        }
        return arr;
    }
}