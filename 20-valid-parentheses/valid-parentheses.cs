public class Solution {
    public bool compare(char a , char b){
        return (a=='(' && b==')') ||(a=='{' && b=='}') || (a=='['&&b==']');
    }
    Stack<char> opens = new Stack<char>();
    public bool IsValid(string s) {
        if(s is null) return false;
        for(int i = 0 ; i<s.Length; i++){
            if(s[i] == '(' || s[i] == '{'|| s[i] == '[') opens.Push(s[i]);
            else {
                if(opens.Count == 0 || !compare(opens.Pop(),s[i])) return false ;
            }
        }
        return opens.Count ==0 ;
    }
}