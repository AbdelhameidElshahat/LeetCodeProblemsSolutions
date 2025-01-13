public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int MaxOnes = 0 ;
        int CurrentOnes = 0 ;
        for(int i = 0 ; i<nums.Length; i++){
            if(nums[i] == 1){
                CurrentOnes +=1;
                MaxOnes = Math.Max(CurrentOnes , MaxOnes);
            }
            else{
                CurrentOnes=0;
            }
        }
        return MaxOnes;
    }
}