public class Solution {
    public bool IsSubsequence(string a, string b) {
        int p1 = 0;
        int p2 = 0;
        if(a.Length == 0) return true;
        while(p1 < a.Length && p2 < b.Length){
            if(a[p1] == b[p2]){
                p1++;
            }
            p2++;
            if(p1 == a.Length) return true;
        }
        return false;
    }
}