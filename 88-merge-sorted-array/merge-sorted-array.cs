public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        for(int i = m  , j =0 ; i < nums1.Length && j <n ;i++ , j++){
            nums1[i] = nums2[j];
        }
        Array.Sort(nums1);
        // int [] nums3 = new int [m+n];
        // int i = 0 ; int j =0 ;
        // for (int index = 0 ; index  < nums3.Length ; index++){
        //     if(nums1[i] <= nums2[j] &&  i < m -1){
        //         nums3[index] = nums1[i];
        //         i++;
        //     }
        //     else if ( nums2[j] < nums1[i] && j <n-1  ){
        //         nums3[index] = nums2[j];
        //         j++;
        //     }
        // }
       
    }
}