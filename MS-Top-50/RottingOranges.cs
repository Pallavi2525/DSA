//LeetCode - 994. Rotting Oranges

public class Solution {
    public int OrangesRotting(int[][] grid) {
        int count = 0;
        int count_fresh = 0;
        Queue<int[]> queue = new Queue<int[]>();
        for(int i = 0; i < grid.Length; i++)
            for(int j = 0; j< grid[0].Length; j++)
            {
                if(grid[i][j] == 2)
                    queue.Enqueue(new int[]{i,j});
                else if(grid[i][j] == 1)
                    count_fresh++;
            }
        if(count_fresh == 0) return 0;
        List<int[]> dirs = new List<int[]>();
        dirs.Add(new int[]{0,1});
        dirs.Add(new int[]{0,-1});
        dirs.Add(new int[]{1,0});
        dirs.Add(new int[]{-1,0});
        while(queue.Count != 0){
            count++;
            int size = queue.Count;
            for(int i = 0; i < size; i++){
                int[] point = queue.Dequeue();
                foreach(int[] dir in dirs){
                    int x = point[0] + dir[0];
                    int y = point[1] + dir[1];
                    if(x < 0 || y < 0 || x >= grid.Length || y >= grid[0].Length || grid[x][y] == 0 || grid[x][y] == 2)
                        continue;
                    grid[x][y] = 2;
                    queue.Enqueue(new int[]{x,y});
                    count_fresh--;
                }
            }
        }
        return count_fresh == 0 ? count-1 : -1;
    }
}