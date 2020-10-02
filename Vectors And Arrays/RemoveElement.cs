public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int length_full=nums.Length;
        int i=0;
        int j=0;
        if(nums.Length>0){
        while(i<length_full){
            if(nums[j]==val){
                j++;
                length_full--;
            }
            else{
                nums[i]=nums[j];
                i++;
                j++;
            }
            
        }
        }
        return length_full;
    
    }
}