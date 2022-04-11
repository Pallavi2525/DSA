public class TicTacToe {
    char[,] board;
    int n;
    public TicTacToe(int _n) {
        board = new char[_n,_n];
        n = _n;
    }
    
    public int Move(int row, int col, int player) {
        if(board[row,col] != 'X' && board[row,col] != 'O'){
            if(player == 1){
                board[row, col] = 'X';
                if(didWin(row, col, player) == 1) return 1;
            }
            else{
                board[row, col] = 'O';
                if(didWin(row, col, player) == 2) return 2;
            }
        }
        return 0;
    }
    
    private int didWin(int row, int col, int player){
        char sign;
        if(player == 1) sign = 'X'; else sign = 'O';
        
        bool didWin = true;
        for(int i = 0; i < n; i++){
            if(board[row,i] != sign)
                didWin = false;
        }
        if(didWin) return player;
        
        didWin = true;
        for(int i = 0; i < n; i++){
            if(board[i,col] != sign)
                didWin = false;
        }
        if(didWin) return player;
        
        if(row == col){
            didWin = true;
            for(int i = 0; i < n; i++){
                if(board[i,i] != sign)
                    didWin = false;
            }
            if(didWin) return player;
        }
        
        if(row == (n - 1 - col)){
            didWin = true;
            for(int i = 0; i < n; i++){
                if(board[i,n - 1 - i] != sign)
                    didWin = false;
            }
            if(didWin) return player;
        }
        return 0;
    }
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */