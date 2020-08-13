using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class MenuForm : Form
    {
        public static int difficulty { get; set; }
        public static int boardSize { get; set; }

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            cbBoardSize.SelectedIndex = 0;
            cbDifficulty.SelectedIndex = 2;

            difficulty = cbDifficulty.SelectedIndex;
            boardSize = cbBoardSize.SelectedIndex == 0 ? 19 : 15;

            populateScores();
        }

        private void btnStartCom_Click(object sender, EventArgs e)
        {
            new GameForm().ShowDialog();
        }

        private void cbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            difficulty = cbDifficulty.SelectedIndex;

            switch (cbDifficulty.SelectedIndex)
            {
                case 0:
                    lblDifficultyDesc.Text = "Computer place it's piece randomly. Player starts first with black piece. The winner of the previous round will start first for the next round.";
                    break;
                case 1:
                    lblDifficultyDesc.Text = "Computer focus on defending only. Player starts first with black piece. The winner of the previous round will start first for the next round.";
                    break;
                default:
                    lblDifficultyDesc.Text = "Computer is capable of attacking and defending. Computer starts first with black piece. The winner of the previous round will start first for the next round.";
                    break;
            }
        }

        private void cbBoardSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            boardSize = cbBoardSize.SelectedIndex == 0 ? 19 : 15;
        }

        private void MenuForm_Activated(object sender, EventArgs e)
        {
            populateScores();
        }

        private void populateScores()
        {
            dgvScores.Rows.Clear();

            string path = AppDomain.CurrentDomain.BaseDirectory + "../../scores.txt";
            if (File.Exists(path) && File.ReadAllLines(path).Length > 0)
            {
                foreach (string l in File.ReadLines(path))
                {
                    string[] data = l.Split(',');

                    dgvScores.Rows.Add(new string[3] { data[0], data[1], data[2] });
                }
            }
        }
    }
}
