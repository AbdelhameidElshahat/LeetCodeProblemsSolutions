public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack  = new Stack<string>();
        foreach(string dir in path.Split("/")){
            if(dir.Length == 0 || dir.Equals(".")){
                continue;
            }
            else if(dir.Equals("..")){
                if(stack.Count > 0 ){
                    stack.Pop();
                }
            }
            else{
                stack.Push(dir);
            }
        }
        StringBuilder sb  = new StringBuilder();
        foreach(string dir in stack.Reverse()){
            sb.Append("/").Append(dir);
        }
        return sb.Length > 0 ? sb.ToString() :"/";
    }
}