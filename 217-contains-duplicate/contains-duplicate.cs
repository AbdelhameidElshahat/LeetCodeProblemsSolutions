public class Solution {
    public bool ContainsDuplicate(int [] nums){
        HashSet<int> sh = new HashSet<int>();
        foreach (int num in nums){
            if(sh.Contains(num))return true;
            else sh.Add(num);
        } 
        return false;
    }
} 