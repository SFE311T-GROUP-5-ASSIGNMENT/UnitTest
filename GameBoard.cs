namespace tictactest
{
    public class GameBoard
    {
        private string[,] board = new string[3, 3];

        public GameBoard(string initialBoardSetup)
        {
            int i = 0;
            foreach (var singleChar in initialBoardSetup)
            {
                board[i % 3, i / 3] = singleChar.ToString();
                i++;
            }
        }

        public string this[int x, int y]
        {
            get
            {
                return this.board[x,y];
            }

            set
            {
                this.board[x, y] = value;
            }
        }
    }
}
