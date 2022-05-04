//LeetCode - 1679. Max Number of K-Sum Pairs

public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int count = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach(int num in nums){
            if(!map.ContainsKey(num))
                map.Add(num, 1);
            else
                map[num]++;
        }
        foreach(int num in nums){
            int val = k - num;
            if(map.ContainsKey(val) && map.ContainsKey(num)){
                if(map[num] > 0 && map[val] > 0){
                    if(num == val && map[val] < 2)
                        continue;
                    map[num]--;
                    map[val]--;
                    count++;
                }
            }
        }
        return count;
    }
}