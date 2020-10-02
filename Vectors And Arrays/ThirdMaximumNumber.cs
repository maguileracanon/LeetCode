public class Solution {
    public int ThirdMax(int[] nums) {
        Array.Sort(nums);
        Array.Reverse(nums);
        int[] maxs = new int[3];
        int i_max=0;
        maxs[0]=nums[0];
        for (int i=1;i<nums.Length;i++){
            if(i_max<2){
                if(nums[i]<maxs[i_max]){
                    maxs[++i_max]=nums[i];

                }
          
            }
            else{
                break;
            }
        }
         
        if (i_max>1){
            return maxs[2];
        }
        else{
            return maxs[0];
        }
        
        
    }
}