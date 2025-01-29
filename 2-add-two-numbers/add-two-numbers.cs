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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(-1);
        ListNode cur = dummyHead;
        int curry = 0 ;
        while(l1 != null || l2 != null || curry != 0  ){
            int x =0 , y=0 ;
            if(l1 != null){
                x=l1.val;
                l1 = l1.next;
            }
            if(l2 != null){
                y=l2.val;
                l2 = l2.next;
            }
            int sum = x + y +curry;
            curry = sum /10;
            cur.next = new ListNode(sum % 10);
            cur = cur.next;

        }   
        return dummyHead.next;
    }
}