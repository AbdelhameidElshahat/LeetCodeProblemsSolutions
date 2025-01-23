/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
        ListNode cur = head;
        if(head == null){
            return false;
         } 
        while(cur != null){
            if(visitedNodes.Contains(cur)){
                return true;
            }
            visitedNodes.Add(cur);
            cur= cur.next;
        }
        return false;
    }
}