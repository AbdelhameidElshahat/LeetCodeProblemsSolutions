public class MyLinkedList {

    ListNode head;
    public MyLinkedList() {
        head = null;
    }
    private ListNode GetNode(int index){
        ListNode cur = head ; 
        for(int i =0 ; i<index && cur != null ; i++){
            cur = cur.next;
        }
        return cur;
    }
    private ListNode GetTail(){
        ListNode cur = head;
        while(cur != null && cur.next != null){
            cur = cur.next;
        }
        return cur;
    }
    
    
    public int Get(int index) {
        ListNode cur = GetNode(index);
        return cur == null ? -1 : cur.val;
    }
    
    public void AddAtHead(int val) {
        ListNode cur = new ListNode(val);
        cur.next = head;
        head = cur; 
    }
    
    public void AddAtTail(int val) {
        if(head == null){
            AddAtHead(val);
            return;
        }
        ListNode prev = GetTail();
        ListNode cur = new ListNode(val);
        prev.next = cur ;
        cur.next = null;
    }
    
    public void AddAtIndex(int index, int val) {
        if(index == 0 ){
            AddAtHead(val);
            return;
        }
        ListNode prev = GetNode(index -1);
        if(prev == null){
            return;
        }
        ListNode cur = new ListNode (val);
        cur.next = prev.next;
        prev.next = cur;
    }
    
    public void DeleteAtIndex(int index) {
        ListNode cur = GetNode(index);
        if(cur == null ){
            return;
        }
        if(index == 0 ){
            head = head.next;
            return;
        }
        ListNode prev = GetNode(index -1);
        prev.next = cur.next;
        cur.next = null;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */