class Solution {
public:
    ListNode  *getNode(int n,ListNode*head ){
        ListNode *cur = head;
        while (n--){
            cur = cur->next;
        }
        return cur;
    }
    ListNode* getMiddle(ListNode * head ){
        ListNode *slow = head;
        ListNode* fast = head;
        while (fast != NULL && fast->next!= NULL){
            slow = slow->next ;
            fast = fast->next->next;
        }
        return slow;
    }
    bool isPalindrome(ListNode* head) {
        ListNode * cur = getMiddle(head);
        ListNode* pre = NULL;
        ListNode * next = NULL;
        while(cur!=NULL){
            next = cur->next;
            cur->next = pre ;
            pre = cur ;
            cur = next;
        }
        ListNode * l = head ;
        ListNode *r = pre;
        while (r != NULL){
            if (r->val != l->val){
                return false ;
            } 
            l = l->next;
            r = r->next;
        } 
        return true;  
    }
};