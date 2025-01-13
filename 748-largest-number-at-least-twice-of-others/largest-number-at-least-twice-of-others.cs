public class Solution {
    public  int DominantIndex(int[] nums)
    {
       int[] nums1 = (int[])nums.Clone();
        Array.Sort(nums);

        if (nums[nums.Length - 2] * 2 <= nums[nums.Length -1] ) 
        {
            return Array.IndexOf(nums1, nums[nums.Length - 1]);
        }
        else
        {
              return -1;
        }
    
    }
}