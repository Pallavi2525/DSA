public class Solution {
    public string Tictactoe(int[][] moves) {
        int n = 3;//moves.Length;
        int[] player1 = new int[2*n + 2];
        int[] player2 = new int[2*n + 2];
        
        for(int i = 0; i < moves.Length; i++){
            int row = moves[i][0];
            int col = moves[i][1];
            //player1
            if(i % 2 == 0){
                player1[row] += 1;
                player1[col + n] += 1;
                if(row == col)
                    player1[ 2*n] += 1;
                if(row == (n - 1 - col))
                    player1[2*n + 1] += 1;
            }
            //player2
            else{
                player2[row] += 1;
                player2[col + n] += 1;
                if(row == col)
                    player2[2*n] += 1;
                if(row == (n - 1 - col))
                    player2[2*n + 1] += 1;
            }
        }
        foreach(int i in player1)
            Console.WriteLine(i.ToString());
        for(int i = 0; i < player1.Length; i++)
        {
            if(player1[i] == n)
                return "A";
            else if(player2[i] == n)
                return "B";
        }
            
        if(moves.Length == n*n)
            return "Draw";
        else
            return "Pending";
    }
}