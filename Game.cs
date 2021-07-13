using System;

namespace tictactest
{
    public class Game
    {
        private string previousMarker;
        private readonly GameBoard board;

        public Game() : this("")
        {

        }

        public Game(string initialBoardSetup)
        {
            board = new GameBoard(initialBoardSetup);
        }
        public void Play(string marker, int x, int y)
        {
            if(marker == this.previousMarker)
            {
                throw new InvalidOperationException();
            }

            if(this.board[x,y] != null)
            {
                throw new InvalidOperationException();
            }

            this.previousMarker = marker;
            this.board[x, y] = marker;
            
        }

        public string GetWinner()
        {
           for(int row=0; row <3; row++ )
            {
                if(RowMarkersAreTheSame(row)&& IsPlayer(0,row))
                {
                    return this.board[0, row];
                }
            }
           for(int col=0; col <3; col++)
            {
                if(ColumnMarkersAreTheSame(col)&& IsPlayer(col,0))
                {
                    return this.board[col, 0];
                }
                   
            }

           if(diagonalMarkersAreTheSame() && IsPlayer(0,0))
            {
                return this.board[0, 0];
            }

           if(OtherdiagonalMarkersAreTheSame() && IsPlayer(0,2))
            {
                return this.board[0, 2];
            }
            return string.Empty;

        }

        private bool IsPlayer(int x, int y) 
        {
            var s = this.board[x, y];
            return s == "X" || s == "O";
        }

        private bool diagonalMarkersAreTheSame()
        {
            if(board[0,0]==board[1,1] && board[1,1]==board[2,2])
            {
                return true;
            }

            return false;
        }

        private bool OtherdiagonalMarkersAreTheSame()
        {
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                return true;
            }

            return false;
        }

        private bool ColumnMarkersAreTheSame(int col)
        {
            if(board[col, 0] == board[col,1] && board[col, 1] == board[col, 2])
            {
                return true;
            }
            return false;
        }

        private bool RowMarkersAreTheSame(int row)
        {
            if(board[0,row] == board[1, row] && board[1, row]==board[2,row])
             {
                return true;
            }
            return false;
        }
    }
}
