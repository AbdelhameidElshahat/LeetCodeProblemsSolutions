public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int counter  = 0 ;
        HashSet<char> sh = new HashSet<char>();
        foreach (char s in jewels){
            sh.Add(s);
        }
        foreach(char s in stones){
            if(sh.Contains(s)) counter ++;
        }
        return counter;
    }
}