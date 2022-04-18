//LeetCode - 200. Number of Islands

public class Solution {
    public int NumIslands(char[][] grid) {
        int count = 0;
        for(int i = 0; i < grid.Length; i++)
            for(int j = 0; j < grid[0].Length; j++)
                if(grid[i][j] == '1')
                {
                    count++;
                    bfs(grid, i , j);
                }
        return count;
    }
    
    private void bfs(char[][] grid, int i, int j){
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            return;
        grid[i][j] = '0';
        bfs(grid, i + 1, j);
        bfs(grid, i - 1, j);
        bfs(grid, i, j + 1);
        bfs(grid, i, j - 1);
    }
}