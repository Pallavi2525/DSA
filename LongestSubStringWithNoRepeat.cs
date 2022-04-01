public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new HashSet<char>();
        int start = 0;
        int end = 0;
        int max = 0;
        while(end < s.Length){
            if(!charSet.Contains(s[end])){
                charSet.Add(s[end]);
                end++;
                max = Math.Max(max,charSet.Count());
            }
            else
            {
                charSet.Remove(s[start]);
                start++;
            }
        }
        return max;
    }
}