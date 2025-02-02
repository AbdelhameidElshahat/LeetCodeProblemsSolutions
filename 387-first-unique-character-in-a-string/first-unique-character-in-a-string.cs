public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char ch in s){
            dict.TryAdd(ch,0);
            dict[ch]++;
        }
        for(int i = 0 ; i<s.Length;i++){
            char c = s[i];
            if(dict[c] ==1) return i;
        }
        return -1;
    }
}