public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int counter=0;
        int maxCounter=0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i]>0) {
                counter++;
            }
            else {
                maxCounter=Math.Max(counter, maxCounter);
                counter=0;
            }
        }
        return Math.Max(counter, maxCounter);
    }
}