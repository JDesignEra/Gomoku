namespace Gomoku
{
    class GameBoard
    {
        public int[,] board { get; } // [Row, Col]. 0 = Empty, 1 = Black, -1 = White

        /// <summary>
        /// Initialize 2D array of game board. Defaults to 19 x 19.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public GameBoard(int row = 19, int col = 19) {
            board = new int[row, col];
        }

        /// <summary>
        /// Place player piece on 2D array board.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="playerPiece"></param>
        public void placePiece(int row, int col, int playerPiece)
        {
            board[row, col] = playerPiece;
        }

        /// <summary>
        /// Check if there is any 5 consecutive pieces for said player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns>Returns int of player numer.</returns>
        public int checkWin(int player)
        {
            // Since board is square, max row & col are the same.
            int boardFill = 0, max = board.GetLength(0),
                counter;

            // Horizontals
            for (int r = 0; r < max; r++)
            {
                counter = 0;
                for (int c = 0; c < max; c++)
                {
                    boardFill += board[r, c] != (int)Piece.empty ? 1 : 0;

                    counter = board[r, c] == player ? counter + 1 : 0;

                    if (counter == 5)
                    {
                        return player;
                    }
                }
            }

            // Verticals
            for (int c = 0; c < max; c++)
            {
                counter = 0;
                for (int r = 0; r < max; r++)
                {
                    counter = board[r, c] == player ? counter + 1 : 0;

                    if (counter == 5)
                    {
                        return player;
                    }
                }
            }

            // Diagonals \ Direction (Skip top-right & bottom-left dead-zone)
            for (int s = 4; s < (max * 2 - 1) - 4; s++)
            {
                counter = 0;
                int z = s < max ? 0 : s - max + 1;

                for (int r = z; r <= s - z; r++)
                {
                    int c = (max - 1) - (s - r);
                    counter = board[r, c] == player ? counter + 1 : 0;

                    if (counter == 5)
                    {
                        return player;
                    }
                }
            }

            // Diagonals / Direction (Skip top-left & bottom-right dead-zone)
            for (int s = 4; s < (max * 2 - 1) - 4; s++)
            {
                counter = 0;
                int z = s < max ? 0 : s - max + 1;

                for (int r = z; r <= s - z; r++)
                {
                    int c = s - r;
                    counter = board[r, c] == player ? counter + 1 : 0;

                    if (counter == 5)
                    {
                        return player;
                    }
                }
            } 

            if (boardFill == board.Length)
            {
                return 3;
            }

            return 0;
        }
    }
}
