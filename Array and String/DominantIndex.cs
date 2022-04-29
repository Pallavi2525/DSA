//LeetCode - 747. Largest Number At Least Twice of Others

public class Solution {
    public int DominantIndex(int[] nums) {
        int maxNum = -1;
        int maxIndex = -1;
        int secMax = -1;
        for(int i = 0; i < nums.Length; i++){
            if(maxNum < nums[i]){
                secMax = maxNum;
                maxNum = nums[i];
                maxIndex = i;
            }
            else if(nums[i] > secMax)
                secMax = nums[i];
        }
        if(secMax*2 > maxNum)
            return -1;
        else
            return maxIndex;
    }
}