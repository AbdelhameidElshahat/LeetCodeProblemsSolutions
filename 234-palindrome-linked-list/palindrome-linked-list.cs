/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        bool isPalindrome= true ;
        Stack<int> st = new Stack<int>();
        ListNode cur = head;
        while(cur != null){
            st.Push(cur.val);
            cur = cur.next;
            }
        cur = head;
        while (cur != null){
            if(cur.val != st.Pop()){
                isPalindrome = false;
                break;
            }
            cur=cur.next;
        }
        return isPalindrome;
    }
}