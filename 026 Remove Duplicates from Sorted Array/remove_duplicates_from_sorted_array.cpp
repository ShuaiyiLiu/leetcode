class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int pt = 0;
        if (nums.size() < 2) return nums.size();
        for (auto n : nums)
            if (nums[pt] != n) nums[++pt] = n;
        return pt + 1;
    }
}; // Author: XC
