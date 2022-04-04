public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        backTrack(ref result, string.Empty, 0, 0, n);
        return result;
    }
    public void backTrack(ref List<string> result, string outputStr, int open, int close, int max){
        //base case - actual insertion - if length of outputStr = max
        if(outputStr.Length == max*2){
            result.Add(outputStr);
            return;
        }
        
        //Decision - 1 - open brackets are less than number of max
        if(open < max)
            backTrack(ref result, outputStr + "(", open + 1, close, max);
        
        //Decision - 2 - closed brackets are more than number of open
        if(close < open)
            backTrack(ref result, outputStr + ")", open, close + 1, max);
    }
}