//LeetCode - 125. Valid Palindrome

public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0;
        int end = s.Length - 1;
        for(start = 0, end = s.Length - 1; start < end; start++, end--){
            while(start < end && !char.IsLetterOrDigit(s[start]))
                start++;
            while(start < end && !char.IsLetterOrDigit(s[end]))
                end--;
            if(char.ToLower(s[start]) != char.ToLower(s[end]))
                return false;
        }
        return true;
    }
}