namespace Gomoku
{
    partial class GameForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.dgvBoard = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbSwords = new System.Windows.Forms.PictureBox();
            this.pbRobot = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblNameSep = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblScoreSep = new System.Windows.Forms.Label();
            this.lblScoreAI = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.lblStoreDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBoard
            // 
            this.dgvBoard.AllowUserToAddRows = false;
            this.dgvBoard.AllowUserToDeleteRows = false;
            this.dgvBoard.AllowUserToResizeColumns = false;
            this.dgvBoard.AllowUserToResizeRows = false;
            this.dgvBoard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoard.ColumnHeadersVisible = false;
            this.dgvBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBoard.EnableHeadersVisualStyles = false;
            this.dgvBoard.Location = new System.Drawing.Point(12, 12);
            this.dgvBoard.MultiSelect = false;
            this.dgvBoard.Name = "dgvBoard";
            this.dgvBoard.RowHeadersVisible = false;
            this.dgvBoard.RowHeadersWidth = 45;
            this.dgvBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            this.dgvBoard.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBoard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBoard.Size = new System.Drawing.Size(705, 705);
            this.dgvBoard.TabIndex = 0;
            this.dgvBoard.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBoard_CellMouseClick);
            this.dgvBoard.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoard_CellMouseEnter);
            this.dgvBoard.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoard_CellMouseLeave);
            this.dgvBoard.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvBoard_RowPrePaint);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.pbLogo);
            this.gbInfo.Controls.Add(this.pbSwords);
            this.gbInfo.Controls.Add(this.pbRobot);
            this.gbInfo.Controls.Add(this.pbPlayer);
            this.gbInfo.Controls.Add(this.lblNameSep);
            this.gbInfo.Controls.Add(this.lblCom);
            this.gbInfo.Controls.Add(this.lblPlayer);
            this.gbInfo.Controls.Add(this.lblScoreSep);
            this.gbInfo.Controls.Add(this.lblScoreAI);
            this.gbInfo.Controls.Add(this.lblScorePlayer);
            this.gbInfo.Controls.Add(this.lblScore);
            this.gbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(724, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(272, 350);
            this.gbInfo.TabIndex = 8;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Game Info";
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbLogo.ErrorImage = null;
            this.pbLogo.Image = global::Gomoku.Properties.Resources.logo;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(3, 192);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(266, 155);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // pbSwords
            // 
            this.pbSwords.ErrorImage = null;
            this.pbSwords.Image = global::Gomoku.Properties.Resources.swords;
            this.pbSwords.InitialImage = null;
            this.pbSwords.Location = new System.Drawing.Point(108, 68);
            this.pbSwords.Name = "pbSwords";
            this.pbSwords.Size = new System.Drawing.Size(56, 56);
            this.pbSwords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSwords.TabIndex = 19;
            this.pbSwords.TabStop = false;
            // 
            // pbRobot
            // 
            this.pbRobot.ErrorImage = null;
            this.pbRobot.Image = global::Gomoku.Properties.Resources.robot;
            this.pbRobot.InitialImage = null;
            this.pbRobot.Location = new System.Drawing.Point(170, 56);
            this.pbRobot.Name = "pbRobot";
            this.pbRobot.Size = new System.Drawing.Size(80, 80);
            this.pbRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRobot.TabIndex = 18;
            this.pbRobot.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.ErrorImage = null;
            this.pbPlayer.Image = global::Gomoku.Properties.Resources.player;
            this.pbPlayer.InitialImage = null;
            this.pbPlayer.Location = new System.Drawing.Point(22, 56);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(80, 80);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 17;
            this.pbPlayer.TabStop = false;
            // 
            // lblNameSep
            // 
            this.lblNameSep.AutoSize = true;
            this.lblNameSep.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSep.Location = new System.Drawing.Point(122, 164);
            this.lblNameSep.Name = "lblNameSep";
            this.lblNameSep.Size = new System.Drawing.Size(27, 25);
            this.lblNameSep.TabIndex = 14;
            this.lblNameSep.Text = " : ";
            this.lblNameSep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCom
            // 
            this.lblCom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblCom.Location = new System.Drawing.Point(154, 164);
            this.lblCom.Name = "lblCom";
            this.lblCom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCom.Size = new System.Drawing.Size(110, 25);
            this.lblCom.TabIndex = 15;
            this.lblCom.Text = "COM";
            this.lblCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lblPlayer.Location = new System.Drawing.Point(7, 164);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPlayer.Size = new System.Drawing.Size(109, 25);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.Text = "YOU";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreSep
            // 
            this.lblScoreSep.AutoSize = true;
            this.lblScoreSep.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreSep.Location = new System.Drawing.Point(122, 139);
            this.lblScoreSep.Name = "lblScoreSep";
            this.lblScoreSep.Size = new System.Drawing.Size(27, 25);
            this.lblScoreSep.TabIndex = 11;
            this.lblScoreSep.Text = " : ";
            this.lblScoreSep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreAI
            // 
            this.lblScoreAI.AutoEllipsis = true;
            this.lblScoreAI.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreAI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblScoreAI.Location = new System.Drawing.Point(154, 139);
            this.lblScoreAI.Name = "lblScoreAI";
            this.lblScoreAI.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblScoreAI.Size = new System.Drawing.Size(110, 25);
            this.lblScoreAI.TabIndex = 12;
            this.lblScoreAI.Text = "0";
            this.lblScoreAI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoEllipsis = true;
            this.lblScorePlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lblScorePlayer.Location = new System.Drawing.Point(7, 139);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblScorePlayer.Size = new System.Drawing.Size(109, 25);
            this.lblScorePlayer.TabIndex = 10;
            this.lblScorePlayer.Text = "0";
            this.lblScorePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(91, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(90, 32);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "SCORE";
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.lblStoreDesc);
            this.gbActions.Controls.Add(this.label2);
            this.gbActions.Controls.Add(this.lblNote);
            this.gbActions.Controls.Add(this.lblNote1);
            this.gbActions.Controls.Add(this.btnStart);
            this.gbActions.Controls.Add(this.btnQuit);
            this.gbActions.Controls.Add(this.btnReset);
            this.gbActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbActions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActions.Location = new System.Drawing.Point(724, 368);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(272, 350);
            this.gbActions.TabIndex = 1;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // lblStoreDesc
            // 
            this.lblStoreDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStoreDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblStoreDesc.Location = new System.Drawing.Point(3, 195);
            this.lblStoreDesc.Name = "lblStoreDesc";
            this.lblStoreDesc.Padding = new System.Windows.Forms.Padding(3);
            this.lblStoreDesc.Size = new System.Drawing.Size(266, 152);
            this.lblStoreDesc.TabIndex = 8;
            this.lblStoreDesc.Text = "Scores are only stored if you or computer has a score of 1 or more.";
            this.lblStoreDesc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Size = new System.Drawing.Size(247, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "* Store current score and return to main menu.";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblNote.Location = new System.Drawing.Point(6, 56);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblNote.Size = new System.Drawing.Size(239, 23);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "* Reset current board, does not affect scores.";
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblNote1.Location = new System.Drawing.Point(6, 114);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblNote1.Size = new System.Drawing.Size(258, 23);
            this.lblNote1.TabIndex = 6;
            this.lblNote1.Text = "* Store current score and reset board and scores.";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(6, 82);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(260, 29);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&START NEW GAME";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(6, 140);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(260, 29);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "&QUIT GAME";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(6, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(260, 29);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&RESET CURRENT GAME";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GameForm
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvBoard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gomoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoard;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label lblScoreAI;
        private System.Windows.Forms.Label lblScoreSep;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblNameSep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStoreDesc;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbRobot;
        private System.Windows.Forms.PictureBox pbSwords;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}