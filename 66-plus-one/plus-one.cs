public class Solution {
    public int[] PlusOne(int[] digits) {
             int n = digits.Length;

        // Start from the end of the array
        for (int i = n - 1; i >= 0; i--)
        {
            // Increment the current digit
            digits[i]++;

            // If the digit is less than 10, no carry, so return the array
            if (digits[i] < 10)
            {
                 return  digits;
            }

            // If the digit is 10, set it to 0 and propagate the carry
            digits[i] = 0;
        }

        // If we reach here, it means there is a carry at the most significant digit
        // Create a new array with an additional digit at the beginning
        int[] newDigits = new int[n + 1];
        newDigits[0] = 1;
         return newDigits;
    }
}