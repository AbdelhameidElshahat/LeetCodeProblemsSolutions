public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> sh = new HashSet<int>(nums2);
        List<int> result = new List<int>();
        foreach (int num in nums1){
            if(sh.Contains(num)) result.Add(num);
             sh.Remove(num);
        }
       
        return result.ToArray();
    }
}