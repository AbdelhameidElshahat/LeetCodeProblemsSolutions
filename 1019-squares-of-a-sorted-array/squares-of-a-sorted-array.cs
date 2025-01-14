public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0 ; 
        int rigth = nums.Length -1 ;
        int index = nums.Length - 1;
        int [] res = new int [nums.Length];
        while(left <= rigth){
            if(Math.Abs(nums[left]) > Math.Abs(nums[rigth])){
                res[index--] = nums[left] * nums[left];
                left++;
            } 
            else{
                res[index--] = nums[rigth] * nums[rigth];
                rigth--;
            }

        }
        return res;
    }
}