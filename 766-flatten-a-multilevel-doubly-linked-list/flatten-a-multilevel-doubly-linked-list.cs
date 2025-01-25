/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        if(head == null) return null;
        Stack<Node>  stack = new Stack<Node>();
        Node cur = head;
        while(cur != null){
        if(cur.child != null){
            if(cur.next != null )stack.Push(cur.next);
            cur.next = cur.child;
            cur.child.prev = cur;
            cur.child=null;
        }
        else if(cur.next ==null && stack.Count > 0 ){
            Node node = stack.Pop();
            cur.next =node;
            node.prev =cur;
        }
        cur = cur.next;
    }
    return head;
    }
}