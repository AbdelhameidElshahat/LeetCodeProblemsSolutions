public class Solution {
 static string SortedString(string s)
  {
      char[] chars = s.ToCharArray();
      Array.Sort(chars);
      return new string (chars);
  }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> anagrams = new Dictionary<string,List<string>>();

        foreach (string str in strs) {
            string sortedStr = SortedString(str);
            if (!anagrams.ContainsKey(sortedStr)) {
                anagrams[sortedStr] = new List<string>();
            }
            anagrams[sortedStr].Add(str);
        }
        IList<IList<string>> result = new List<IList<string>>();
        foreach (var group in anagrams.Values) {
            result.Add(group);
        }
        return result;
    }
}