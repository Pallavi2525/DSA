//LeetCode - 703. Kth Largest Element in a Stream

public class KthLargest {

    private PriorityQueue<int, int> minHeap = null;
    private int k;
    public KthLargest(int _k, int[] nums) {
        minHeap = new PriorityQueue<int, int>();
        k = _k;
        foreach(var num in nums)
            minHeap.Enqueue(num, num);
        while(minHeap.Count > k)
            minHeap.Dequeue();
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        if(minHeap.Count > k)
            minHeap.Dequeue();
        return minHeap.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */