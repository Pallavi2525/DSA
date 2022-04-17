//LeetCode - 168. Excel Sheet Column Title

public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string res = string.Empty;
        int mod;
        while(columnNumber > 0){
            mod = 'A' + (columnNumber - 1) % 26;
            res = Convert.ToChar(mod) + res;
            columnNumber = (columnNumber - 1)/26;
        }
        return res;
    }
}