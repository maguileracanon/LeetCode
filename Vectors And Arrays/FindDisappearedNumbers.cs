public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        ArrayList result = new ArrayList();
        for (int i = 0; i < nums.Length; i++) {
            int val = Math.Abs(nums[i]) - 1;
            if (nums[val] > 0) {
                nums[val] = -nums[val];
            }
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                result.Add(i + 1);
            }
        }
        return result.Cast<int>().ToList();  
    
    }
    
}