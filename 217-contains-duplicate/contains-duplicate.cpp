class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        unordered_set<int> mapping;
        for (int n : nums) {
            if (mapping.find(n) != mapping.end())
                return true;
            mapping.insert(n);
        }
        return false;
    }
};