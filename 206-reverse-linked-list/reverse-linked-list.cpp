class Solution {
public:
    ListNode* reverseList(ListNode* head) {
        ListNode* cur = head;
        ListNode* pre =NULL;
        ListNode*next = NULL;
        while (cur!= NULL){
            next = cur->next;
            cur->next = pre ;
            pre = cur ;
            cur = next;
        }
        return pre;
    }
};