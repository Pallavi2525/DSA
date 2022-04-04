public class Solution {
    public int MyAtoi(string s) {
        if(s.Trim().Length == 0)
            return 0;
        int sign = 1;
        s = s.Trim();
        int index = 0;
        if(index < s.Length && (s[index] == '-' || s[index] == '+'))
        {
            sign = s[index] == '-' ? -1 : 1;
            index++;
        }
        int num = 0;
        int ascii = 0;
        while(index < s.Length && char.IsDigit(s[index])){
            ascii = s[index] - '0';
            if(num > (int.MaxValue-ascii)/10)
                return (sign == -1) ? int.MinValue : int.MaxValue;
            num = num*10 + ascii;
            index++;
        }
        return sign*num;
    }
}