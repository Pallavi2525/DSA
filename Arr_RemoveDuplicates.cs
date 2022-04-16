//LeetCode - 26. Remove Duplicates from Sorted Array

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            if(i< nums.Length -1 && nums[i] == nums[i+1])
                continue;
            nums[count++] = nums[i];
        }
        return count;
    }
}
