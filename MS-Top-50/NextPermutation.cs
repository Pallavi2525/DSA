//LeetCode - 31. Next Permutation

public class Solution {
    public void NextPermutation(int[] nums) {//[1,3,2]
        int breakPoint = 0;
        int ind2= 0;
        for(breakPoint = nums.Length - 2; breakPoint >= 0; breakPoint--){
            if(nums[breakPoint] < nums[breakPoint+1]){
                break;
            }
        }
        if(breakPoint >= 0){
            for(int i = nums.Length - 1; i > breakPoint; i--){
                if(nums[i] > nums[breakPoint]){
                    ind2 = i;
                    break;
                }
            }
            swap(ref nums[breakPoint], ref nums[ind2]);
        }
        reverse(ref nums, breakPoint + 1);
    }
    private void swap(ref int num1, ref int num2){
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    private void reverse(ref int[] nums, int start){
        int end = nums.Length - 1;
        while(start < end){
            swap(ref nums[start], ref nums[end]);
            start++; end--;
        }
    }
}