using System;
using System.Collections.Generic;
using System.Linq;

namespace Gomoku
{
    class AI
    {
        /// <summary>
        /// AI difficulty. Default or 0 = Dumb, 1 = Normal and 2 = Hard.
        /// </summary>
        public int difficulty { get; set; }
        public int aiPiece { get; set; }
        public int humanPiece { get; set; }

        /// <summary>
        /// AI random dumb move for Dumb difficulty.
        /// </summary>
        /// <param name="gameboard"></param>
        /// <returns></returns>
        public int[] dumbMove(GameBoard gameboard)
        {
            int[,] board = gameboard.board;

            // Since board is square, max row & col are the same.
            int max = board.GetLength(0), r, c;
            Random random = new Random();

            do
            {
                r = random.Next(max);
                c = random.Next(max);
            }
            while (board[r, c] != 0);

            return new int[] { r, c };
        }

        /// <summary>
        /// AI smart move for normal diffculty. Only defend or place pieces randomly.
        /// </summary>
        /// <param name="gameboard"></param>
        /// <returns></returns>
        public int[] smartMove(GameBoard gameboard)
        {
            int[] defend = decision(gameboard, false);

            if (defend[0] == -1 || defend[1] == -1)
            {
                return dumbMove(gameboard);
            }

            return new int[2] { defend[0], defend[1] };
        }

        /// <summary>
        /// AI intelligent move for hard diffculty.
        /// Attack and defend, and plays more aggressively or defensively based on wheather AI goes first or second.
        /// </summary>
        /// <param name="gameboard"></param>
        /// <returns></returns>
        public int[] intelligentMove(GameBoard gameboard)
        {
            int[] defend = decision(gameboard, false);
            int[] attack = decision(gameboard, true);

            if (aiPiece == (int)Piece.white) // Play more defensively if AI start 2nd
            {
                if (defend[2] >= attack[2] && defend[0] > -1 && defend[1] > -1)
                {
                    return new int[2] { defend[0], defend[1] };
                }
                else if (attack[0] > -1 && attack[1] > -1)
                {
                    return new int[2] { attack[0], attack[1] };
                }
            }
            else if (aiPiece == (int)Piece.black) // Play more aggressively if AI start 1st
            {
                if (attack[2] >= defend[2] && attack[0] > -1 && attack[1] > -1)
                {
                    return new int[2] { attack[0], attack[1] };
                }
                else if (defend[0] > -1 && defend[1] > -1)
                {
                    return new int[2] { defend[0], defend[1] };
                }
            }

            return dumbMove(gameboard);
        }

        /// <summary>
        /// AI decision on where to place it's piece for smart and intelligent AI.
        /// If offensive is true, it will find attack space, or else it will find defensive space.
        /// </summary>
        /// <param name="gameboard"></param>
        /// <param name="offensive"></param>
        /// <returns></returns>
        private int[] decision(GameBoard gameboard, bool offensive = false)
        {
            int[,] board = gameboard.board;

            List<int[]> choices = new List<int[]>();
            int max = board.GetLength(0), // Since board is square, max row & col are the same.
                target = offensive ? aiPiece : humanPiece,
                futureCount, counter,
                high = 0;

            // Horizontal
            for (int x = 0; x < max; x++)
            {
                counter = 0;
                for (int y = 0; y < max; y++)
                {
                    counter = board[x, y] == target ? counter + 1 : 0;

                    if (counter > 0 && counter >= high)
                    {
                        if (y + 1 < max && board[x, y + 1] == (int)Piece.empty)
                        {
                            for (futureCount = 1;
                                futureCount < 5 && y + futureCount < max
                                && (board[x, y + futureCount] == (int)Piece.empty || board[x, y + futureCount] == target);
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x, y + 1, counter });
                            }
                        }

                        if (y - counter > -1 && board[x, y - counter] == (int)Piece.empty)
                        {
                            for (futureCount = counter;
                                futureCount < 5 && y - futureCount > -1
                                && (board[x, y - futureCount] == (int)Piece.empty || board[x, y - futureCount] == target);
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x, y - counter, counter });
                            }
                        }
                    }
                }
            }
            
            // Vertical
            for (int y = 0; y < max; y++)
            {
                counter = 0;
                for (int x = 0; x < max; x++)
                {
                    counter = board[x, y] == target ? counter + 1 : 0;

                    if (counter > 0 && counter >= high)
                    {
                        if (x + 1 < max && board[x + 1, y] == (int)Piece.empty)
                        {
                            for (futureCount = 1;
                                futureCount < 5 && x + futureCount < max
                                && (board[x + futureCount, y] == (int)Piece.empty || board[x + futureCount, y] == target);
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x + 1, y, counter });
                            }
                        }

                        if (x - counter > -1 && board[x - counter, y] == (int)Piece.empty)
                        {
                            for (futureCount = counter;
                                futureCount < 5 && x - futureCount > -1
                                && (board[x - futureCount, y] == (int)Piece.empty || board[x - futureCount, y] == target);
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x - counter, y, counter });
                            }
                        }
                    }
                }
            }
            
            // Diagonals \ Direction (Dead-zone corners are skipped)
            for (int s = 4; s < (max * 2 - 1) - 4; s++)
            {
                counter = 0;
                int z = s < max ? 0 : s - max + 1;

                for (int x = z; x <= s - z; x++)
                {
                    int y = (max - 1) - (s - x);
                    counter = board[x, y] == target ? counter + 1 : 0;

                    if (counter > 0 && counter >= high)
                    {
                        if (x - counter > -1 && y - counter > -1 && board[x - counter, y - counter] == (int)Piece.empty)
                        {
                            for (futureCount = counter;
                                futureCount < 5 && x - futureCount > -1 && y - futureCount > -1
                                && (board[x - futureCount, y - futureCount] == (int)Piece.empty || board[x - futureCount, y - futureCount] == target);
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x - counter, y - counter, counter });
                            }
                        }

                        if (x + 1 < max && y + 1 < max && board[x + 1, y + 1] == (int)Piece.empty)
                        {
                            for (futureCount = counter;
                                futureCount < 5 && x + futureCount < max && y + futureCount < max
                                && (board[x + futureCount, y + futureCount] == (int)Piece.empty || board[x + futureCount, y + futureCount] == target);
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x + 1, y + 1, counter });
                            }
                        }
                    }
                }
            }
            
            // Diagonals / Direction (Dead-zone corners are skipped)
            for (int s = 4; s < (max * 2 - 1) - 4; s++)
            {
                counter = 0;
                int z = s < max ? 0 : s - max + 1;

                for (int x = z; x <= s - z; x++)
                {
                    int y = s - x;
                    counter = board[x, y] == target ? counter + 1 : 0;

                    if (counter > 0 && counter >= high)
                    {
                        if (x - counter > -1 && y + counter < max && board[x - counter, y + counter] == (int)Piece.empty)
                        {
                            for (futureCount = counter; 
                                futureCount < 5 && x - futureCount > -1 && y + futureCount < max 
                                && (board[x - futureCount, y + futureCount] == (int)Piece.empty || board[x - futureCount, y + futureCount] == target); 
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x - counter, y + counter, counter });
                            }
                        }

                        if (x + 1 < max && y - 1 > -1 && board[x + 1, y - 1] == (int)Piece.empty)
                        {
                            for (futureCount = counter; 
                                futureCount < 5 && x + futureCount < max && y - futureCount > -1 
                                && (board[x + futureCount, y - futureCount] == (int)Piece.empty || board[x + futureCount, y - futureCount] == target); 
                                futureCount++) ;

                            if (futureCount == 5)
                            {
                                if (counter > high)
                                {
                                    choices.Clear();
                                }

                                high = counter;
                                choices.Add(new int[] { x + 1, y - 1, counter });
                            }
                        }
                    }
                }
            }

            if (!choices.Any())
            {
                return new int[3] { -1, -1, 0 };
            }

            Random random = new Random();
            return choices[random.Next(choices.Count)];
        }
    }
}
