public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length; 
        int maxRigth  = -1 ; 
        for (int i = n -1 ; i>= 0 ; i-- ){
            int current = arr[i];
            arr[i] = maxRigth; 
            maxRigth = Math.Max(maxRigth , current);
        }
        return arr;
    }
}
