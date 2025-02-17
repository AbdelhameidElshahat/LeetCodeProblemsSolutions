public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
       bool [] visited  = new bool[rooms.Count];
       Stack<int> stack = new Stack<int>();
       stack.Push(0);
       visited[0] = true;
       while(stack.Count>0){
        int node = stack.Pop();
        foreach(int nei in rooms[node]){
            if(!visited[nei]){
                visited[nei] = true;
                stack.Push(nei);
            }
        }
    }
       foreach (bool v in visited){
            if(!v) return false;
       }
        return true;
    }
}