public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        if(intervals.Count() == 0)
            return true;
        Array.Sort(intervals, (start, end) => start[0] - end[0]);
        int start = intervals[0][0];
        int end = intervals[0][1];
        for(int i = 0; i < intervals.Count() - 1; i++){
            int[] i1 = intervals[i];
            int[] i2 = intervals[i + 1];
            //overlapped, merge, move
            if(i1[1] > i2[0]){
                return false;
            }
        }
        return true;
    }
}