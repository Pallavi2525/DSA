public class Solution {
    public bool IsPalindrome(int x) {
        int num = x;
        if(x < 0)
            return false;
        int rem = 0;
        int reversed = 0;
        while(x > 0){
            rem = x % 10;
            reversed = reversed * 10 + rem;
            x = x / 10;
        }
        System.Console.Write(reversed.ToString());
        if(reversed == num)
            return true;
        else
            return false;
    }
}