public class Solution {
    public int[] SortedSquares(int[] nums) {
        List<int> arrResult = new List<int>();
        foreach(int i in nums){
            arrResult.Add(i*i);
        }
        int[] result = arrResult.ToArray();
        Array.Sort(result);
        return result;
    }
}