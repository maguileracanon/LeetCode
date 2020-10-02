public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //m is where nums2 start
        for(int i=m;i<nums1.Length; i++){
            nums1[i]=nums2[i-m];
        }
        Array.Sort(nums1);
    }
}