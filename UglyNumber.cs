public class Solution {
    public bool IsUgly(int n) {
        if(n > 0){
        for(int i = 2; i < 6; i++){
            while(n % i == 0){
                n = n / i;
            }
        }
        if(n == 1)
            return true;
        else
            return false;
        }
        return false;
    }
}