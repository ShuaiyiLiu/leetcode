// Author: Xinyu Chen
public class Solution {
    public int SingleNumber(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[0] ^= nums[i];
        }
        return nums[0];
    }
}