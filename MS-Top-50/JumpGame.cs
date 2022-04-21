//LeetCode - 55. Jump Game

public class Solution {
    public bool CanJump(int[] nums) {
        int reachable = 0;
        for(int i = 0; i < nums.Length; i++){
            if(reachable < i)
                return false;
            reachable = Math.Max(reachable, i + nums[i]);
        }
        return true;
    }
}