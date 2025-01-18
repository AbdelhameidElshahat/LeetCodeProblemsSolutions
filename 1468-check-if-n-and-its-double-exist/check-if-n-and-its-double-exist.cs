public class Solution {
     public bool CheckIfExist(int[] arr) {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in arr) {
            // Check if num is double of a seen number or half of a seen number
            if (seen.Contains(2 * num) || (num % 2 == 0 && seen.Contains(num / 2))) {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}
