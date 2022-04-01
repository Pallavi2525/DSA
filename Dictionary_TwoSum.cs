public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        int req = 0;
        var dictVisited = new Dictionary<int,int>();
        for( int i = 0; i < nums.Length; i++){
            req = target - nums[i];
            if(dictVisited.ContainsKey(req))
            {
                res[1] = i;
                res[0] = dictVisited[req];
            }
            else
            if(!dictVisited.ContainsKey(nums[i]))
                dictVisited.Add(nums[i],i);
        }
        return res;
    }
}