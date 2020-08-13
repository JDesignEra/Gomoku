using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class GameForm : Form
    {
        private AI ai = new AI();
        private GameBoard gameboard;

        private bool gameState = true; // If true, game is still ongoing. Else game has ended.
        private int[] playersScore = new int[2]; // [Human Player, AI]
        private int[] playersPiece = new int[2]; // [Human Player, AI]

        private Dictionary<string, Image> assets = new Dictionary<string, Image>()
        {
            { "board", Properties.Resources.board },
            { "white", Properties.Resources.white },
            { "black", Properties.Resources.black },
            { "white_hover", Properties.Resources.white_hover },
            { "black_hover", Properties.Resources.black_hover }
        };

        public GameForm()
        {
            InitializeComponent();
            string difficultyTxt = MenuForm.difficulty == 2 ? "Hard" : MenuForm.difficulty == 1 ? "Normal" : "Dumb";

            this.Text = "Gomoku - Player VS " + difficultyTxt + " Computer";
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            gameboard = new GameBoard(MenuForm.boardSize, MenuForm.boardSize);

            ai.difficulty = MenuForm.difficulty;

            playersPiece = ai.difficulty == 2 ? new int[2] { (int)Piece.white, (int)Piece.black } : new int[2] { (int)Piece.black, (int)Piece.white };

            ai.aiPiece = playersPiece[1];
            ai.humanPiece = playersPiece[0];

            // Create Columns
            for (int i = 0; i < gameboard.board.GetLength(1); i++)
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Width = dgvBoard.Width / gameboard.board.GetLength(1);
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imgCol.DefaultCellStyle.NullValue = null;
                imgCol.HeaderText = (i + 1).ToString();

                dgvBoard.Columns.Add(imgCol);
            }

            // Create Rows
            for (int i = 0; i < gameboard.board.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = dgvBoard.Height / gameboard.board.GetLength(0);
                row.HeaderCell.Value = (i + 1).ToString();

                dgvBoard.Rows.Add(row);
            }
            
            if (playersPiece[1] == (int)Piece.black)
            {
                aiMove();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            storeScore(playersScore, ai.difficulty);
        }

        private void dgvBoard_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.Graphics.DrawImage(assets["board"], e.RowBounds);
        }

        private void dgvBoard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvBoard[e.ColumnIndex, e.RowIndex].Tag == null || dgvBoard[e.ColumnIndex, e.RowIndex].Tag as string == "black_hover" || dgvBoard[e.ColumnIndex, e.RowIndex].Tag as string == "white_hover")
            {
                // Player Move
                if (gameState)
                {
                    placePiece(e.RowIndex, e.ColumnIndex, playersPiece[0]);
                }

                // AI Move
                if (gameState)
                {
                    aiMove();
                }
            }
        }

        private void dgvBoard_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoard[e.ColumnIndex, e.RowIndex].Tag == null)
            {
                if (playersPiece[0] == (int)Piece.black)
                {
                    dgvBoard[e.ColumnIndex, e.RowIndex].Value = assets["black_hover"];
                    dgvBoard[e.ColumnIndex, e.RowIndex].Tag = "black_hover";
                }
                else
                {
                    dgvBoard[e.ColumnIndex, e.RowIndex].Value = assets["white_hover"];
                    dgvBoard[e.ColumnIndex, e.RowIndex].Tag = "white_hover";
                }
            }
        }

        private void dgvBoard_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoard[e.ColumnIndex, e.RowIndex].Tag as string == "black_hover" || dgvBoard[e.ColumnIndex, e.RowIndex].Tag as string == "white_hover")
            {
                dgvBoard[e.ColumnIndex, e.RowIndex].Value = null;
                dgvBoard[e.ColumnIndex, e.RowIndex].Tag = null;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            storeScore(playersScore, ai.difficulty);

            playersScore = new int[2];
            lblScorePlayer.Text = "0";
            lblScoreAI.Text = "0";

            if (ai.difficulty == 2)
            {
                playersPiece = new int[2] { (int)Piece.white, (int)Piece.black };
            }
            else
            {
                playersPiece = new int[2] { (int)Piece.black, (int)Piece.white };
            }

            resetGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetGame()
        {
            gameboard = new GameBoard(gameboard.board.GetLength(0), gameboard.board.GetLength(1));
            
            ai.aiPiece = playersPiece[1];
            ai.humanPiece = playersPiece[0];

            gameState = true;

            for (int c = 0; c < dgvBoard.Columns.Count; c++)
            {
                for (int r = 0; r < dgvBoard.Rows.Count; r++)
                {
                    dgvBoard[c, r].Value = null;
                    dgvBoard[c, r].Tag = null;
                }
            }

            if (playersPiece[1] == (int)Piece.black)
            {
                aiMove();
            }
        }

        private void aiMove()
        {
            int[] indexes = new int[2]; // [Row, Col.]

            if (ai.difficulty == 2)
            {
                indexes = ai.intelligentMove(gameboard);
            }
            else if (ai.difficulty == 1)
            {
                indexes = ai.smartMove(gameboard);
            }
            else
            {
                indexes = ai.dumbMove(gameboard);
            }

            placePiece(indexes[0], indexes[1], playersPiece[1]);
        }

        private void placePiece(int row, int col, int playerPiece)
        {
            gameboard.placePiece(row, col, playerPiece);

            dgvBoard[col, row].Value = playerPiece == 1 ? assets["black"] : assets["white"];
            dgvBoard[col, row].Tag = playerPiece == 1 ? "black" : "white";

            checkWin(playerPiece);
        }

        private void checkWin(int playerPiece)
        {
            string message = "Use the Reset Current Game or Start New Game button to start your next game.";
            int winVal = gameboard.checkWin(playerPiece);

            if (playersPiece[0] == winVal)
            {
                playersPiece[0] = (int)Piece.black;
                playersPiece[1] = (int)Piece.white;
                playersScore[0]++;

                int currentScore;
                bool flag = int.TryParse(lblScorePlayer.Text, out currentScore);

                lblScorePlayer.Text = flag ? (currentScore + 1).ToString() : lblScorePlayer.Text;
                MessageBox.Show(message, "YOU HAVE WON THE GAME");
            }
            else if (playersPiece[1] == winVal)
            {
                playersPiece[0] = (int)Piece.white;
                playersPiece[1] = (int)Piece.black;
                playersScore[1]++;

                int currentScore;
                bool flag = int.TryParse(lblScoreAI.Text, out currentScore);

                lblScoreAI.Text = flag ? (currentScore + 1).ToString() : lblScoreAI.Text;
                MessageBox.Show(message, "COMPUTER HAVE WON THE GAME.");
            }
            else if (winVal == 3)
            {
                MessageBox.Show(message, "THE GAME IS A DRAW");
            }

            if (winVal != 0)
            {
                gameState = false;
            }
        }

        private void storeScore(int[] playersScore, int difficulty)
        {
            string difficultyTxt;

            switch (difficulty)
            {
                case 1:
                    difficultyTxt = "Normal";
                    break;
                case 2:
                    difficultyTxt = "Hard";
                    break;
                default:
                    difficultyTxt = "Dumb";
                    break;
            }

            if (playersScore[0] > 0 || playersScore[1] > 0)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "../../scores.txt";
                string data = "";

                // Retrive scores for appending new data later
                if (File.Exists(path) && File.ReadAllLines(path).Length > 0)
                {
                    foreach (string l in File.ReadLines(path))
                    {
                        data += l + '\n';
                    }
                }

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(difficultyTxt + "," + playersScore[0] + "," + playersScore[1]);
                    sw.Write(data);
                }
            }
        }
    }
}
