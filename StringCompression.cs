public class Solution {
    public int Compress(char[] chars) {
        if(chars.Length == 1)
            return 1;
        string str = string.Empty;
        str = str + chars[0];
        int count = 1;
        for(int i = 1; i < chars.Length; i++){
            if(chars[i] != chars[i - 1]){
                if(count > 1)
                {
                    str = str + count.ToString();
                    count = 1;
                }
                str = str + chars[i];
            }
            else
                count++;
        }
        if(count > 1)
            str = str + count.ToString();
        for(int ind = 0; ind < str.Length; ind++){
            chars[ind] = str[ind];
        }
        return str.Length;
    }
}