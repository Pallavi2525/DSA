public class Solution {
    public string DecodeString(string s) {
        string result = string.Empty;
        Stack<int> counts = new Stack<int>();
        Stack<string> strings = new Stack<string>();
        int index = 0;
        
        while(index < s.Length){
            //2,3
            if(char.IsDigit(s[index])){
                int count = 0;
                while(char.IsDigit(s[index])){
                    count = count*10 + (s[index] - '0');
                    index++;
                }
                //counts => 2, counts => 3
                counts.Push(count);
                //index = 1,7
            }
            //[
            else if(s[index] == '['){
                //strings => "", abcabc at index = 7
                strings.Push(result);
                //result = ""
                result = string.Empty;
                index++;
                //index = 2,8
            }
            else if(s[index] == ']'){
                //coutns => empty now, count = 2, counts => empty, count = 3
                int count = counts.Pop();
                //strings => empty now, temp = ""; strings => empty, temp = abcabc
                string temp = strings.Pop();
                for(int i = 0; i < count; i++){
                    //i = 0, temp = abc
                    //i = 1, temp = abcabc
                    //i = 0, temp = abcabccd
                    //i = 1, temp = abcabccdcd
                    //i = 2; temp = abcabccdcdcd
                    temp = temp + result;
                }
                //result = abcabc
                //result = abcabccdcdcd
                result = temp;
                index++;
                //index = 6,11
            }
            else{
                //result = abc, cd, abcabccdcdcde,abcabccdcdcdef
                result = result + s[index];
                index++;
                //index = 3,4,5,9,10,11,12
            }
        }
        return result;
    }
}