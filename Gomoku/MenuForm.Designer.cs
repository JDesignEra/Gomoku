namespace Gomoku
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStartCom = new System.Windows.Forms.Button();
            this.gbDifficultyDesc = new System.Windows.Forms.GroupBox();
            this.pbBrain = new System.Windows.Forms.PictureBox();
            this.lblDifficultyDesc = new System.Windows.Forms.Label();
            this.gbCom = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoardSize = new System.Windows.Forms.ComboBox();
            this.pbRobot = new System.Windows.Forms.PictureBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.gbScores = new System.Windows.Forms.GroupBox();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.colDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScorePlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbDifficultyDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrain)).BeginInit();
            this.gbCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).BeginInit();
            this.gbAbout.SuspendLayout();
            this.gbScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCom
            // 
            this.btnStartCom.AutoSize = true;
            this.btnStartCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnStartCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCom.ForeColor = System.Drawing.Color.White;
            this.btnStartCom.Location = new System.Drawing.Point(6, 165);
            this.btnStartCom.Name = "btnStartCom";
            this.btnStartCom.Size = new System.Drawing.Size(261, 31);
            this.btnStartCom.TabIndex = 4;
            this.btnStartCom.Text = "&START";
            this.btnStartCom.UseVisualStyleBackColor = false;
            this.btnStartCom.Click += new System.EventHandler(this.btnStartCom_Click);
            // 
            // gbDifficultyDesc
            // 
            this.gbDifficultyDesc.Controls.Add(this.pbBrain);
            this.gbDifficultyDesc.Controls.Add(this.lblDifficultyDesc);
            this.gbDifficultyDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDifficultyDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDifficultyDesc.Location = new System.Drawing.Point(443, 210);
            this.gbDifficultyDesc.Name = "gbDifficultyDesc";
            this.gbDifficultyDesc.Padding = new System.Windows.Forms.Padding(10);
            this.gbDifficultyDesc.Size = new System.Drawing.Size(274, 202);
            this.gbDifficultyDesc.TabIndex = 0;
            this.gbDifficultyDesc.TabStop = false;
            this.gbDifficultyDesc.Text = "Difficulty Description";
            // 
            // pbBrain
            // 
            this.pbBrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBrain.ErrorImage = null;
            this.pbBrain.Image = global::Gomoku.Properties.Resources.brain;
            this.pbBrain.InitialImage = null;
            this.pbBrain.Location = new System.Drawing.Point(10, 28);
            this.pbBrain.Name = "pbBrain";
            this.pbBrain.Size = new System.Drawing.Size(254, 70);
            this.pbBrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrain.TabIndex = 7;
            this.pbBrain.TabStop = false;
            // 
            // lblDifficultyDesc
            // 
            this.lblDifficultyDesc.AutoEllipsis = true;
            this.lblDifficultyDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDifficultyDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDifficultyDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultyDesc.Location = new System.Drawing.Point(10, 109);
            this.lblDifficultyDesc.Name = "lblDifficultyDesc";
            this.lblDifficultyDesc.Size = new System.Drawing.Size(254, 83);
            this.lblDifficultyDesc.TabIndex = 0;
            this.lblDifficultyDesc.Text = "Computer is capable of attacking and defending. Computer starts first with black " +
    "piece. The winner of the previous round will start first for the next round.";
            // 
            // gbCom
            // 
            this.gbCom.Controls.Add(this.label2);
            this.gbCom.Controls.Add(this.cbBoardSize);
            this.gbCom.Controls.Add(this.pbRobot);
            this.gbCom.Controls.Add(this.lblDifficulty);
            this.gbCom.Controls.Add(this.cbDifficulty);
            this.gbCom.Controls.Add(this.btnStartCom);
            this.gbCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCom.Location = new System.Drawing.Point(723, 210);
            this.gbCom.Name = "gbCom";
            this.gbCom.Size = new System.Drawing.Size(273, 202);
            this.gbCom.TabIndex = 0;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Play With Computer";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Board Size";
            // 
            // cbBoardSize
            // 
            this.cbBoardSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoardSize.AutoCompleteCustomSource.AddRange(new string[] {
            "19 x 19",
            "15 x 15"});
            this.cbBoardSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoardSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoardSize.FormattingEnabled = true;
            this.cbBoardSize.Items.AddRange(new object[] {
            "19 x 19",
            "15 x 15"});
            this.cbBoardSize.Location = new System.Drawing.Point(82, 134);
            this.cbBoardSize.Name = "cbBoardSize";
            this.cbBoardSize.Size = new System.Drawing.Size(185, 25);
            this.cbBoardSize.TabIndex = 2;
            this.cbBoardSize.Text = "Select Board Size";
            this.cbBoardSize.SelectedIndexChanged += new System.EventHandler(this.cbBoardSize_SelectedIndexChanged);
            // 
            // pbRobot
            // 
            this.pbRobot.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbRobot.ErrorImage = null;
            this.pbRobot.Image = global::Gomoku.Properties.Resources.robot;
            this.pbRobot.InitialImage = null;
            this.pbRobot.Location = new System.Drawing.Point(3, 21);
            this.pbRobot.Name = "pbRobot";
            this.pbRobot.Size = new System.Drawing.Size(267, 70);
            this.pbRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRobot.TabIndex = 4;
            this.pbRobot.TabStop = false;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(6, 106);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(57, 17);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDifficulty.AutoCompleteCustomSource.AddRange(new string[] {
            "Dumb",
            "Normal",
            "Hard"});
            this.cbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDifficulty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Dumb",
            "Normal",
            "Hard"});
            this.cbDifficulty.Location = new System.Drawing.Point(82, 103);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(185, 25);
            this.cbDifficulty.TabIndex = 1;
            this.cbDifficulty.Text = "Select Difficulty";
            this.cbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cbDifficulty_SelectedIndexChanged);
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.rtbAbout);
            this.gbAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAbout.Location = new System.Drawing.Point(443, 418);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Padding = new System.Windows.Forms.Padding(10);
            this.gbAbout.Size = new System.Drawing.Size(553, 299);
            this.gbAbout.TabIndex = 9;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "What is Gomoku?";
            // 
            // rtbAbout
            // 
            this.rtbAbout.BackColor = System.Drawing.SystemColors.Control;
            this.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAbout.Enabled = false;
            this.rtbAbout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAbout.Location = new System.Drawing.Point(10, 28);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ReadOnly = true;
            this.rtbAbout.Size = new System.Drawing.Size(533, 261);
            this.rtbAbout.TabIndex = 10;
            this.rtbAbout.TabStop = false;
            this.rtbAbout.Text = resources.GetString("rtbAbout.Text");
            // 
            // gbScores
            // 
            this.gbScores.Controls.Add(this.dgvScores);
            this.gbScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbScores.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScores.Location = new System.Drawing.Point(12, 210);
            this.gbScores.Name = "gbScores";
            this.gbScores.Padding = new System.Windows.Forms.Padding(10);
            this.gbScores.Size = new System.Drawing.Size(425, 507);
            this.gbScores.TabIndex = 7;
            this.gbScores.TabStop = false;
            this.gbScores.Text = "Scores History";
            // 
            // dgvScores
            // 
            this.dgvScores.AllowUserToAddRows = false;
            this.dgvScores.AllowUserToDeleteRows = false;
            this.dgvScores.AllowUserToResizeColumns = false;
            this.dgvScores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgvScores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvScores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDifficulty,
            this.colScorePlayer,
            this.colScoreAI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvScores.EnableHeadersVisualStyles = false;
            this.dgvScores.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvScores.Location = new System.Drawing.Point(10, 28);
            this.dgvScores.Margin = new System.Windows.Forms.Padding(0);
            this.dgvScores.MultiSelect = false;
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.ReadOnly = true;
            this.dgvScores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvScores.RowHeadersVisible = false;
            this.dgvScores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.dgvScores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScores.ShowCellErrors = false;
            this.dgvScores.ShowCellToolTips = false;
            this.dgvScores.ShowEditingIcon = false;
            this.dgvScores.ShowRowErrors = false;
            this.dgvScores.Size = new System.Drawing.Size(405, 469);
            this.dgvScores.TabIndex = 8;
            // 
            // colDifficulty
            // 
            this.colDifficulty.HeaderText = "Difficulty";
            this.colDifficulty.Name = "colDifficulty";
            this.colDifficulty.ReadOnly = true;
            // 
            // colScorePlayer
            // 
            this.colScorePlayer.HeaderText = "Player Score";
            this.colScorePlayer.Name = "colScorePlayer";
            this.colScorePlayer.ReadOnly = true;
            // 
            // colScoreAI
            // 
            this.colScoreAI.HeaderText = "COM. Score";
            this.colScoreAI.Name = "colScoreAI";
            this.colScoreAI.ReadOnly = true;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.ErrorImage = null;
            this.pbLogo.Image = global::Gomoku.Properties.Resources.logo;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1008, 192);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbScores);
            this.Controls.Add(this.gbAbout);
            this.Controls.Add(this.gbCom);
            this.Controls.Add(this.gbDifficultyDesc);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gomoku - Menu";
            this.Activated += new System.EventHandler(this.MenuForm_Activated);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.gbDifficultyDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBrain)).EndInit();
            this.gbCom.ResumeLayout(false);
            this.gbCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).EndInit();
            this.gbAbout.ResumeLayout(false);
            this.gbScores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStartCom;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbDifficultyDesc;
        private System.Windows.Forms.GroupBox gbCom;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.RichTextBox rtbAbout;
        private System.Windows.Forms.PictureBox pbRobot;
        private System.Windows.Forms.GroupBox gbScores;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScorePlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreAI;
        private System.Windows.Forms.Label lblDifficultyDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoardSize;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.PictureBox pbBrain;
    }
}

