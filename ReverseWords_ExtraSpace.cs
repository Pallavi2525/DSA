public class Solution {
    public string ReverseWords(string s) {
        s = s.TrimStart().TrimEnd();
        Stack<string> stack = new Stack<string>();
        foreach(string word in s.Split(" ")){
            if(!string.IsNullOrEmpty(word))
                stack.Push(word);
        }
        s = string.Empty;
        while(stack.Count != 0){
            s = s + stack.Pop() + " ";
        }
        return s.TrimEnd();
    }
}