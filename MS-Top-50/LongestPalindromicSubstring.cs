//LeetCode - 5. Longest Palindromic Substring

public class Solution {
    public string LongestPalindrome(string s) {
        int resLen = 0;
        string res = "";
        for(int i = 0; i < s.Length; i++){//i=0
            int l = i;//0
            int r = i;//0
            while(l >= 0 && r < s.Length && s[l] == s[r])
            {
                if((r - l + 1) > resLen){
                    resLen = r - l + 1;//1
                    res = s.Substring(l, resLen);//
                }
                l--;
                r++;
            }
            l = i;
            r = i + 1;
            while(l >= 0 && r < s.Length && s[l] == s[r])
            {
                if((r - l + 1) > resLen){
                    resLen = r - l + 1;
                    res = s.Substring(l, resLen);
                }
                l--;
                r++;
            }
        }
        return res;
    }
}