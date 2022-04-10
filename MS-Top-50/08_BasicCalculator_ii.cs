public class Solution {
    public int Calculate(string s) {
        int strLen = s.Length;
        Stack<int> stack = new Stack<int>();
        string sign = "+";
        for(int i = 0; i < strLen ; i++){
            if(char.IsDigit(s[i])){
                int val = 0;
                while(i < strLen && char.IsDigit(s[i])){
                    val = val*10 + (s[i] - '0');
                    i++;
                }
                i--;
                if(sign == "+")
                    stack.Push(val);
                else if(sign == "-")
                    stack.Push(-val);
                else if(sign == "*"){
                    int ans = stack.Pop();
                    ans = ans * val;
                    stack.Push(ans);
                }
                else if(sign == "/"){
                    int ans = stack.Pop();
                    ans = ans / val;
                    stack.Push(ans);
                }
            }
            else if(s[i] != ' '){
                sign = s[i].ToString();
            }
        }
        int sum = 0;
        while(stack.Count != 0)
            sum = sum + stack.Pop();
        return sum;
    }
}