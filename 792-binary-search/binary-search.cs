public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2; // Avoids integer overflow

            if (nums[mid] == target) {
                return mid; // Return the index, not the value
            }
            else if (nums[mid] > target) {
                right = mid - 1; // Search the left half
            }
            else {
                left = mid + 1; // Search the right half
            }
        }

        return -1; // Target not found
    }
}