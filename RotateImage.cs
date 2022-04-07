public class Solution {
    public void Rotate(int[][] matrix) {
        //transpose
        for(int i = 0; i < matrix.Length; i++){
            for(int j = i; j < matrix[0].Length; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        //reverse each row
        for(int i = 0; i < matrix.Length; i++){
            for(int j = 0; j < matrix[i].Length/2; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix[i].Length - 1 - j];
                matrix[i][matrix[i].Length - 1 - j] = temp;
            }
        }
    }
}