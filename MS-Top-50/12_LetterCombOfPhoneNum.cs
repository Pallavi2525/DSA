public class Solution {
    private Dictionary<int,string> map = new Dictionary<int,string>()
    {
        {'2',"abc"},
        {'3',"def"},
        {'4',"ghi"},
        {'5',"jkl"},
        {'6',"mno"},
        {'7',"pqrs"},
        {'8',"tuv"},
        {'9',"wxyz"}
    };
    private List<string> list = new List<string>();
    public IList<string> LetterCombinations(string digits) {
        if(digits.Length == 0)
            return list;
        backTrack(0,"", digits);
        return list;
    }
    private void backTrack(int index, string curString, string digits){
        if(curString.Length == digits.Length)
        {
            list.Add(curString);
            return;
        }
        foreach(char c in map[digits[index]]){
            backTrack(index + 1, curString + c, digits);
        }
    }
}