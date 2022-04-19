//LeetCode - 54. Spiral Matrix

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> res = new List<int>();
        int right = matrix[0].Length;//3
        int left = 0;
        int top = 0;
        int bottom = matrix.Length;//3
        
        while(left < right && top < bottom){
            //top row
            for(int i = left; i < right; i++)//i = 0 to 2
                res.Add(matrix[top][i]);
            top++;//1
            
            //right col
            for(int i = top; i < bottom; i++)//i = 1 to 2
                res.Add(matrix[i][right - 1]);
            right--;//2
            
            if(!(left < right && top < bottom))
                break;
            
            //bottom row
            for(int i = right - 1; i >= left; i--)//i = 1 to 0
                res.Add(matrix[bottom-1][i]);
            bottom--;//2
            
            //left col
            for(int i = bottom - 1; i >= top; i--)//i = 1 to 1
                res.Add(matrix[i][left]);
            left++;
        }
        
        return res;
    }
}