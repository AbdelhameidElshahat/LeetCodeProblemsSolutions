public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int nums1ptr = 0 ; 
        int nums2ptr = 0 ; 
        int[] temp = new int [n+m];

        for(int i = 0 ; i< temp.Length; i++){
            if( nums1ptr == m ){
                temp [i] = nums2[nums2ptr];
                nums2ptr++;
            }
            else if (nums2ptr == n){
                temp [i] = nums1[nums1ptr];
                nums1ptr++;
            }
            else if ( nums1[nums1ptr] < nums2[nums2ptr] ){
                temp [i] = nums1[nums1ptr];
                nums1ptr++;
            }
            else if( nums2[nums2ptr] <= nums1[nums1ptr]){
                temp[i] =nums2[nums2ptr];
                nums2ptr++;
            }
        }
       for (int i = 0 ; i < temp.Length; i++){
        nums1[i] = temp[i];
       }
    }
}