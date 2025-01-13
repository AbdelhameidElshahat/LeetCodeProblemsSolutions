    public class Solution
    {

        public int PivotIndex(int[] nums)
        {
           int LeftSum = 0; int TotalSum = nums.Sum();
        for (int i = 0; i < nums.Length; i++)
        {
        int RigthSum = TotalSum - LeftSum -nums[i];
        if (LeftSum == RigthSum)
        {
            return i;
        }
        LeftSum += nums[i];
        }
        return -1;
    }
   }