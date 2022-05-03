//LeetCode - 347. Top K Frequent Elements

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if(nums.Length == k)
            return nums;
        int[] result = new int[k];
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        foreach(int num in nums){
            if(!freqMap.ContainsKey(num))
                freqMap.Add(num, 1);
            else
                freqMap[num]++;
        }
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        foreach(var item in freqMap){
            heap.Enqueue(item.Key, item.Value);
            if(heap.Count > k)
                heap.Dequeue();
        }
        for(int i = 0 ; i < k; i++){
            result[i] = heap.Dequeue();
        }
        return result;
    }
}