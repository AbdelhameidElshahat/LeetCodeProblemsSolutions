class Solution {
public:
    vector<int> minOperations(string boxes) {
        vector<int>ans(boxes.size()) ; int ones =0 ; int sumOnes =0 ;
        
        for(int i=0 ;i<boxes.size();i++){
            sumOnes += ones ;
            ans[i]+= sumOnes;
            if(boxes[i]=='1'){
                ones++;
            }
        }
        ones =0 ; sumOnes =0 ;
        for(int i = boxes.size()-1;i>=0 ;i--){
            sumOnes+=ones ;
            ans[i]+=sumOnes ;
            if(boxes[i]=='1'){
                ones++;
            }
        }
        return ans;
    }
};