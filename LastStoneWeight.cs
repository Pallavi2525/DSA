//LeetCode - 1046. Last Stone Weight

public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        foreach(var stone in stones)
            maxHeap.Enqueue(stone, -stone);
        while(maxHeap.Count > 1){
            int largest = maxHeap.Dequeue();
            int secLargest = maxHeap.Dequeue();
            if(largest == secLargest)
                continue;
            else{
                int newNum = largest - secLargest;
                maxHeap.Enqueue(newNum, -newNum);
            }
        }
        return maxHeap.Count == 0 ? 0 : maxHeap.Peek();
    }
}