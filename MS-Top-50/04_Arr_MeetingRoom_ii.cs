public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        if(intervals.Count() == 0)
            return 0;
        
        int[] start = new int[intervals.Count()];
        for(int i = 0; i < start.Length; i++){
            start[i] = intervals[i][0];
        }
        int[] end = new int[intervals.Count()];
        for(int i = 0; i < start.Length; i++){
            end[i] = intervals[i][1];
        }
        Array.Sort(start);
        Array.Sort(end);
        
        int count = 0;
        int max = 0;
        int s = 0;
        int e = 0;
        
        while(s < intervals.Count()){
            if(start[s] < end[e]){
                count++;
                s++;
            }
            else{
                e++;
                count--;
            }
            max = Math.Max(count, max);
        }
        
        return max;
    }
}