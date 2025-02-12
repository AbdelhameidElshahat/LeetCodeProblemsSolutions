public class Solution {
    Stack<int> stack = new Stack<int>();
    HashSet<string> sh = new HashSet<string>() { "+", "-", "*", "/" };

    public int EvalRPN(string[] tokens) {
        foreach (string token in tokens) {
            if (sh.Contains(token)) {
                int y = stack.Pop();
                int x = stack.Pop();
                if (token == "+") {
                    stack.Push(x + y);
                } else if (token == "-") {
                    stack.Push(x - y);
                } else if (token == "*") {
                    stack.Push(x * y);
                } else if (token == "/") {
                    stack.Push(x / y);
                }
            } else { 
                stack.Push(int.Parse(token)); 
            }
        }
        return stack.Pop();
    }
}