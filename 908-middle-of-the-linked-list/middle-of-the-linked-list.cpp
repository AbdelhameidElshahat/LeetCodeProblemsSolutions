class Solution {
public:
    ListNode* middleNode(ListNode* head) {
        ListNode * cur = head ;
        int c =0 ;
        while (cur != NULL){
            c++;
            cur = cur->next;
        }
        ListNode* goal = head;
        for(int i = 0 ;i<c/2;i++){
            goal =goal->next;
        }
        return goal;
    }
};