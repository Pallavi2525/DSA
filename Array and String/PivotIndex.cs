//LeetCode - 724. Find Pivot Index

public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        int leftSum = 0;
        foreach(int num in nums)
            sum += num;
        for(int i = 0; i < nums.Length; i++){
            if(leftSum == sum - nums[i] - leftSum)
                return i;
            leftSum += nums[i];
        }
        return -1;
    }
}