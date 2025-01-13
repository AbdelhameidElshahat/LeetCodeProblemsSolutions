public class Solution {
    public int FindNumbers(int[] nums) {
       int num = nums.Select(x => x.ToString()).Count(x => x.Length % 2 == 0);
       return num;
    }
}