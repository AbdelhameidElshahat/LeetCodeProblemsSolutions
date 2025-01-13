public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
        foreach(int i in nums)
        {
                if((i.ToString().Length) %2 == 0) 
                {count = count+1; }
        }
        return count;
    }
}