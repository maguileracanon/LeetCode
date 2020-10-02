public class Solution {
    public void MoveZeroes(int[] nums) {
        int full_legth=nums.Length;
        int i=0;
        while(i<full_legth){
            if (nums[i]==0){
                for(int k=i;k<nums.Length-1;k++) {
                    nums[k]=nums[k+1];
                }
            
                nums[full_legth-1]=0;
                full_legth--;
                
            }
            else{
                i++;
            }
        }

    }
}