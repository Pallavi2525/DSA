public class Solution {
    public int ArraySign(int[] nums) {
        BigInteger product = 1;
        for(int i = 0; i < nums.Length; i++)
            product = product * nums[i];
        if(product > 0)
            return 1;
        else if(product < 0)
            return -1;
        else
            return 0;
    }
}