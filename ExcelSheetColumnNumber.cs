public class Solution {
    public int TitleToNumber(string columnTitle) {
        int sum = 0;
        foreach(char c in columnTitle.ToCharArray()){
            sum = sum*26 + (c - 'A' + 1);
        }
        return sum;
    }
}

//B = 2
//BC = B*26 + C
//BCD = (B*26 + C)*26 + D