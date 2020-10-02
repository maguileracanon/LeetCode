public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int full_legth=nums.Length;
        int i=0;
        int j=i+1;
        while (j<nums.Length){
            
            if(nums[i]==nums[j]){
                j++;
                full_legth--;
            }
            else{
                i++;
                nums[i]=nums[j];
                j++;
            }
        }
     return full_legth; 
    }
}