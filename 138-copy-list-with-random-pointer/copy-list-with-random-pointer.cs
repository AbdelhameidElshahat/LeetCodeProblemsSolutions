/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    Dictionary<Node,Node> visited = new Dictionary<Node,Node>();
    private Node GetCloneNode (Node node){
        if(node == null)return null;
        if(visited.ContainsKey(node)){
            return visited[node];
        }
        visited.Add(node, new Node(node.val));
        return visited[node];
    }
    public Node CopyRandomList(Node head) {
       if(head == null) return null;
        Node cur = head;
        Node copy = new Node (cur.val);
        visited[cur] =copy;
        while(cur != null){
            copy.next = GetCloneNode(cur.next);
            copy.random = GetCloneNode(cur.random);
            cur = cur.next ; 
            copy = copy.next;
       }
       return visited[head];
    }
}