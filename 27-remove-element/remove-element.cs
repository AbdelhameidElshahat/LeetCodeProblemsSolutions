public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int writer = 0;
        for (int reader  = 0 ; reader < nums.Length; reader++){
            if(nums[reader] != val){
                nums[writer++] = nums[reader];
            }
        }
        return writer;
        //nums = (int[]) res.Clone();
        //return nums.Length
        //return k;
    }
}