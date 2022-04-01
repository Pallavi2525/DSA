public class Solution {
    public int Reverse(int x) {
        var sign = 1;
        if (x < 0) {
            sign = -1;
            x = x*sign;
        }
        int result = 0;
        while(x > 0){
            if(result*sign<Int32.MinValue/10 || result*sign>Int32.MaxValue/10)
                return 0;
            int rem = x % 10;      //123%10 = 3, 120%10 = 0, 12%10 = 2, 1%10 = 1
            result = (result * 10) + rem;   //0 + 3, 3*10 + 0 = 30, 30*10+2=32, 320+1 = 321
            
            x = x /10;          //123/10 = 120,  120/10 = 12, 12/10 = 1, 1/10 = 0
        }
        return sign*result;
    }
}
//2147483647
