//LeetCode - 977. Squares of a Sorted Array

public class Solution {
    public int[] SortedSquares(int[] nums) {
        int square = 0;
        int n = nums.Length;
        int[] result = new int[n];
        int left = 0;
        int right = n - 1;
        for(int i = n - 1; i >= 0; i--){
            if(Math.Abs(nums[left]) < Math.Abs(nums[right])){
            square = nums[right];
            right--;
        }
        else{
            square = nums[left];
            left++;
        }
        square = square * square;
        result[i] = square;
        }
        return result;
    }
}