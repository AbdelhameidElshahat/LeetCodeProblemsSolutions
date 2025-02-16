public class Solution {
    public string DecodeString(string s) {
        Stack<int> countStack  = new Stack<int>();
        Stack<string> resStack = new Stack<string>();
        string res = "";
        int idx = 0 ;
        while(idx<s.Length){
            if(char.IsDigit(s[idx])){
               int num = 0 ;
               while(char.IsDigit(s[idx])){
                num = num * 10 +s[idx] - '0';
                idx++;
               }
               countStack.Push(num);
            }
            else if(s[idx] =='['){
                resStack.Push(res);
                res = "";
                idx++;
            }
            else if(s[idx] ==']'){
                StringBuilder sb = new StringBuilder (resStack.Pop());
                int repeatTimes = countStack.Pop();
                for(int i = 0 ; i<repeatTimes;i++){
                    sb.Append(res);
                }
                res = sb.ToString();
                idx++;
            }
            else{
                res +=s[idx];
                idx++;
            }

        }
        return res;
    }
}