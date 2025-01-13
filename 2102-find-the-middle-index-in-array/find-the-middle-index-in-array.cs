public class Solution {
    public int FindMiddleIndex(int[] nums) 
        {
            int totalSum = nums.Sum(); // Precompute the total sum of the array
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate rightSum using the formula: rightSum = totalSum - leftSum - nums[i]
                int rightSum = totalSum - leftSum - nums[i];

                // Check if leftSum equals rightSum
                if (leftSum == rightSum)
                {
                    return i; // Return the current index as the pivot index
                }

                // Update leftSum for the next iteration
                leftSum += nums[i];
            }

         return -1; // No pivot index found
        }
}