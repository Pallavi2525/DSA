public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        //List of arrays - result
        List<int[]> list = new List<int[]>();
        
        //edge case - return empty list for empty input
        if(intervals.Length == 0 || intervals == null)
            return (new int[0][]);
        
        //sort the arrays first - O(NlogN)
        Array.Sort(intervals,(a,b)=>a[0] - b[0]);
        
        int start = intervals[0][0];
        int end = intervals[0][1];
        
        foreach(int[] interval in intervals){
            //is interval merged? yes - merge and move to next iteration
            //[1,3],[2,6] => [1,6] => 2<=3 true => end = max(3,6) => think of what would have happened if it was actually [1,7] => to handle such cases we do max
            if(interval[0] <= end)
                end = Math.Max(end, interval[1]);
            //interval not merged, add to list
            else{
                list.Add(new int[]{start, end});
                start = interval[0];
                end = interval[1];
            }
        }
        list.Add(new int[]{start, end});
        return list.ToArray();
    }
}