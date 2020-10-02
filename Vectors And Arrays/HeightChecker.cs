public class Solution {
    public int HeightChecker(int[] heights) {
        //int[] hights_sorted = heights; /This is only a pointer
        int[] hights_sorted = new int[heights.Length];
        heights.CopyTo(hights_sorted,0);
        int counter=0;
        Array.Sort(hights_sorted);


        for(int i=0; i<heights.Length;i++){
            if(heights[i]!=hights_sorted[i]){
                counter++;
            }
        }
        return counter;
    }
}