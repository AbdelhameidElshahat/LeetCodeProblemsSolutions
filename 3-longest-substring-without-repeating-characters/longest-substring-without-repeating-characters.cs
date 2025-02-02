public class Solution {
    public int LengthOfLongestSubstring(string s) {
      int left = 0 , rigth = 0 , res = 0;
      int n = s.Length;
      HashSet<char> sh = new HashSet<char>();
      while(left<n &&rigth < n){
        while(sh.Contains(s[rigth])){
            sh.Remove(s[left++]);
        }
        sh.Add(s[rigth++]);
        res = Math.Max(res , rigth - left);
      }
      return res;
    }
}