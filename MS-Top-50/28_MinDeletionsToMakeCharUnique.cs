public class Solution {
    public int MinDeletions(string s) {
        int result = 0;
        Dictionary<char,int> dic = s.GroupBy(c=>c).ToDictionary(c=>c.Key, c=>c.Count());
        HashSet<int> hs = new HashSet<int>();
        foreach(var item in dic){
            int cur = item.Value;
            while(cur> 0  && !hs.Add(cur)){
                result++;
                cur--;
            }
        }
        return result;
    }
}