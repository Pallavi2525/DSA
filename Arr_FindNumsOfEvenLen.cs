public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;
        string strNum;
        foreach(int i in nums){
            strNum = i.ToString();
            if(strNum.Length%2 == 0)
                result++;
        }
        return result;
    }
}