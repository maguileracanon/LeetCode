public class Solution {
    public int FindNumbers(int[] nums) {
        int counter=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i].ToString().Length % 2 == 0){
                counter++;
            }
    
        }
        return counter;
    }
    
    
}