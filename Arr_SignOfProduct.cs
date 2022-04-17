//LeetCode - 1822. Sign of the Product of an Array

public class Solution {
    public int ArraySign(int[] nums) {
        int sign = 1;
        foreach(int num in nums){
	        if(num < 0)
  	            sign = -sign;
            else if(num == 0)
  	        sign = 0;
        }
        return sign;
    }
}