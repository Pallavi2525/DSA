//LeetCode - 498. Diagonal Traverse

public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        // if(mat.Length == 0)
        //     return new int[0];
        int rows = mat.Length;
        int cols = mat[0].Length;
        int r = 0;
        int c = 0;
        int[] result = new int[rows*cols];
        for(int i = 0; i < result.Length; i++){
            result[i] = mat[r][c];
            //up
            if((r + c) % 2 == 0){
                if(c == cols - 1){
                    r++;
                }
                else if(r == 0){
                    c++;
                }
                else
                {
                    r--;
                    c++;
                }
            }
            //down
            else{
                if(r == rows - 1){
                    c++;
                }
                else if(c == 0){
                    r++;
                }
                else{
                    r++;
                    c--;
                }
            }
        }
        return result;
    }
}

//00,01,02,10,11,12,20,21,22
//0,1,2,1,2,3,2,3,4