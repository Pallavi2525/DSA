public class Solution {
    public void SortColors(int[] nums) {
        int countZero = 0;
        int countOne = 0;
        int countTwo = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0)
                countZero++;
            if(nums[i] == 1)
                countOne++;
            if(nums[i] == 2)
                countTwo++;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(i<countZero) nums[i] = 0;
            else if(i>= countZero && i < countOne+countZero) nums[i] = 1;
            else nums[i] = 2;
        }
    }
}