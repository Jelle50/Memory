using System.Drawing;

namespace Memory
{
    partial class MemoryGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryGame));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNieuwSpel = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.pctbx12 = new System.Windows.Forms.PictureBox();
            this.pctbx17 = new System.Windows.Forms.PictureBox();
            this.pctbx18 = new System.Windows.Forms.PictureBox();
            this.pctbx19 = new System.Windows.Forms.PictureBox();
            this.pctbx20 = new System.Windows.Forms.PictureBox();
            this.pctbx13 = new System.Windows.Forms.PictureBox();
            this.pctbx14 = new System.Windows.Forms.PictureBox();
            this.pctbx15 = new System.Windows.Forms.PictureBox();
            this.pctbx16 = new System.Windows.Forms.PictureBox();
            this.pctbx9 = new System.Windows.Forms.PictureBox();
            this.pctbx10 = new System.Windows.Forms.PictureBox();
            this.pctbx11 = new System.Windows.Forms.PictureBox();
            this.pctbx5 = new System.Windows.Forms.PictureBox();
            this.pctbx6 = new System.Windows.Forms.PictureBox();
            this.pctbx7 = new System.Windows.Forms.PictureBox();
            this.pctbx8 = new System.Windows.Forms.PictureBox();
            this.pctbx4 = new System.Windows.Forms.PictureBox();
            this.pctbx3 = new System.Windows.Forms.PictureBox();
            this.pctbx2 = new System.Windows.Forms.PictureBox();
            this.pctbx1 = new System.Windows.Forms.PictureBox();
            this.lblTitleScreen = new System.Windows.Forms.Label();
            this.btnBeginSpel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1056, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNieuwSpel});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmNieuwSpel
            // 
            this.tsmNieuwSpel.Name = "tsmNieuwSpel";
            this.tsmNieuwSpel.Size = new System.Drawing.Size(224, 26);
            this.tsmNieuwSpel.Text = "Niew spel";
            this.tsmNieuwSpel.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(712, 130);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(93, 38);
            this.lblTurn.TabIndex = 22;
            this.lblTurn.Text = "Turn:";
            this.lblTurn.Visible = false;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(753, 180);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(137, 38);
            this.lblCurrentPlayer.TabIndex = 23;
            this.lblCurrentPlayer.Text = "Player 1";
            this.lblCurrentPlayer.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(712, 229);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(112, 38);
            this.lblScore.TabIndex = 24;
            this.lblScore.Text = "Score:";
            this.lblScore.Visible = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(753, 279);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(146, 38);
            this.lblPlayer1.TabIndex = 25;
            this.lblPlayer1.Text = "Player 1:";
            this.lblPlayer1.Visible = false;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(753, 324);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(146, 38);
            this.lblPlayer2.TabIndex = 26;
            this.lblPlayer2.Text = "Player 2:";
            this.lblPlayer2.Visible = false;
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer2.Location = new System.Drawing.Point(900, 324);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(35, 38);
            this.lblScorePlayer2.TabIndex = 28;
            this.lblScorePlayer2.Text = "0";
            this.lblScorePlayer2.Visible = false;
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer1.Location = new System.Drawing.Point(900, 279);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(35, 38);
            this.lblScorePlayer1.TabIndex = 27;
            this.lblScorePlayer1.Text = "0";
            this.lblScorePlayer1.Visible = false;
            // 
            // pctbx12
            // 
            this.pctbx12.Enabled = false;
            this.pctbx12.Location = new System.Drawing.Point(313, 119);
            this.pctbx12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx12.Name = "pctbx12";
            this.pctbx12.Size = new System.Drawing.Size(100, 100);
            this.pctbx12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx12.TabIndex = 21;
            this.pctbx12.TabStop = false;
            this.pctbx12.Visible = false;
            this.pctbx12.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx17
            // 
            this.pctbx17.Enabled = false;
            this.pctbx17.Location = new System.Drawing.Point(543, 463);
            this.pctbx17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx17.Name = "pctbx17";
            this.pctbx17.Size = new System.Drawing.Size(100, 100);
            this.pctbx17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx17.TabIndex = 20;
            this.pctbx17.TabStop = false;
            this.pctbx17.Visible = false;
            this.pctbx17.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx18
            // 
            this.pctbx18.Enabled = false;
            this.pctbx18.Location = new System.Drawing.Point(543, 350);
            this.pctbx18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx18.Name = "pctbx18";
            this.pctbx18.Size = new System.Drawing.Size(100, 100);
            this.pctbx18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx18.TabIndex = 19;
            this.pctbx18.TabStop = false;
            this.pctbx18.Visible = false;
            this.pctbx18.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx19
            // 
            this.pctbx19.Enabled = false;
            this.pctbx19.Location = new System.Drawing.Point(543, 234);
            this.pctbx19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx19.Name = "pctbx19";
            this.pctbx19.Size = new System.Drawing.Size(100, 100);
            this.pctbx19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx19.TabIndex = 18;
            this.pctbx19.TabStop = false;
            this.pctbx19.Visible = false;
            this.pctbx19.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx20
            // 
            this.pctbx20.Enabled = false;
            this.pctbx20.Location = new System.Drawing.Point(543, 119);
            this.pctbx20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx20.Name = "pctbx20";
            this.pctbx20.Size = new System.Drawing.Size(100, 100);
            this.pctbx20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx20.TabIndex = 17;
            this.pctbx20.TabStop = false;
            this.pctbx20.Visible = false;
            this.pctbx20.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx13
            // 
            this.pctbx13.Enabled = false;
            this.pctbx13.Location = new System.Drawing.Point(428, 463);
            this.pctbx13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx13.Name = "pctbx13";
            this.pctbx13.Size = new System.Drawing.Size(100, 100);
            this.pctbx13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx13.TabIndex = 16;
            this.pctbx13.TabStop = false;
            this.pctbx13.Visible = false;
            this.pctbx13.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx14
            // 
            this.pctbx14.Enabled = false;
            this.pctbx14.Location = new System.Drawing.Point(428, 350);
            this.pctbx14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx14.Name = "pctbx14";
            this.pctbx14.Size = new System.Drawing.Size(100, 100);
            this.pctbx14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx14.TabIndex = 15;
            this.pctbx14.TabStop = false;
            this.pctbx14.Visible = false;
            this.pctbx14.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx15
            // 
            this.pctbx15.Enabled = false;
            this.pctbx15.Location = new System.Drawing.Point(428, 234);
            this.pctbx15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx15.Name = "pctbx15";
            this.pctbx15.Size = new System.Drawing.Size(100, 100);
            this.pctbx15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx15.TabIndex = 14;
            this.pctbx15.TabStop = false;
            this.pctbx15.Visible = false;
            this.pctbx15.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx16
            // 
            this.pctbx16.Enabled = false;
            this.pctbx16.Location = new System.Drawing.Point(428, 119);
            this.pctbx16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx16.Name = "pctbx16";
            this.pctbx16.Size = new System.Drawing.Size(100, 100);
            this.pctbx16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx16.TabIndex = 13;
            this.pctbx16.TabStop = false;
            this.pctbx16.Visible = false;
            this.pctbx16.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx9
            // 
            this.pctbx9.Enabled = false;
            this.pctbx9.Location = new System.Drawing.Point(313, 463);
            this.pctbx9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx9.Name = "pctbx9";
            this.pctbx9.Size = new System.Drawing.Size(100, 100);
            this.pctbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx9.TabIndex = 12;
            this.pctbx9.TabStop = false;
            this.pctbx9.Visible = false;
            this.pctbx9.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx10
            // 
            this.pctbx10.Enabled = false;
            this.pctbx10.Location = new System.Drawing.Point(313, 350);
            this.pctbx10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx10.Name = "pctbx10";
            this.pctbx10.Size = new System.Drawing.Size(100, 100);
            this.pctbx10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx10.TabIndex = 11;
            this.pctbx10.TabStop = false;
            this.pctbx10.Visible = false;
            this.pctbx10.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx11
            // 
            this.pctbx11.Enabled = false;
            this.pctbx11.Location = new System.Drawing.Point(313, 234);
            this.pctbx11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx11.Name = "pctbx11";
            this.pctbx11.Size = new System.Drawing.Size(100, 100);
            this.pctbx11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx11.TabIndex = 10;
            this.pctbx11.TabStop = false;
            this.pctbx11.Visible = false;
            this.pctbx11.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx5
            // 
            this.pctbx5.Enabled = false;
            this.pctbx5.Location = new System.Drawing.Point(197, 463);
            this.pctbx5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx5.Name = "pctbx5";
            this.pctbx5.Size = new System.Drawing.Size(100, 100);
            this.pctbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx5.TabIndex = 8;
            this.pctbx5.TabStop = false;
            this.pctbx5.Visible = false;
            this.pctbx5.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx6
            // 
            this.pctbx6.Enabled = false;
            this.pctbx6.Location = new System.Drawing.Point(197, 350);
            this.pctbx6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx6.Name = "pctbx6";
            this.pctbx6.Size = new System.Drawing.Size(100, 100);
            this.pctbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx6.TabIndex = 7;
            this.pctbx6.TabStop = false;
            this.pctbx6.Visible = false;
            this.pctbx6.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx7
            // 
            this.pctbx7.Enabled = false;
            this.pctbx7.Location = new System.Drawing.Point(197, 234);
            this.pctbx7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx7.Name = "pctbx7";
            this.pctbx7.Size = new System.Drawing.Size(100, 100);
            this.pctbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx7.TabIndex = 6;
            this.pctbx7.TabStop = false;
            this.pctbx7.Visible = false;
            this.pctbx7.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx8
            // 
            this.pctbx8.Enabled = false;
            this.pctbx8.Location = new System.Drawing.Point(197, 119);
            this.pctbx8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx8.Name = "pctbx8";
            this.pctbx8.Size = new System.Drawing.Size(100, 100);
            this.pctbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx8.TabIndex = 5;
            this.pctbx8.TabStop = false;
            this.pctbx8.Visible = false;
            this.pctbx8.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx4
            // 
            this.pctbx4.Enabled = false;
            this.pctbx4.Location = new System.Drawing.Point(83, 463);
            this.pctbx4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx4.Name = "pctbx4";
            this.pctbx4.Size = new System.Drawing.Size(100, 100);
            this.pctbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx4.TabIndex = 4;
            this.pctbx4.TabStop = false;
            this.pctbx4.Visible = false;
            this.pctbx4.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx3
            // 
            this.pctbx3.Enabled = false;
            this.pctbx3.Location = new System.Drawing.Point(83, 350);
            this.pctbx3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx3.Name = "pctbx3";
            this.pctbx3.Size = new System.Drawing.Size(100, 100);
            this.pctbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx3.TabIndex = 3;
            this.pctbx3.TabStop = false;
            this.pctbx3.Visible = false;
            this.pctbx3.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx2
            // 
            this.pctbx2.Enabled = false;
            this.pctbx2.Location = new System.Drawing.Point(83, 234);
            this.pctbx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx2.Name = "pctbx2";
            this.pctbx2.Size = new System.Drawing.Size(100, 100);
            this.pctbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx2.TabIndex = 2;
            this.pctbx2.TabStop = false;
            this.pctbx2.Visible = false;
            this.pctbx2.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // pctbx1
            // 
            this.pctbx1.Enabled = false;
            this.pctbx1.Location = new System.Drawing.Point(83, 119);
            this.pctbx1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbx1.Name = "pctbx1";
            this.pctbx1.Size = new System.Drawing.Size(100, 100);
            this.pctbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx1.TabIndex = 1;
            this.pctbx1.TabStop = false;
            this.pctbx1.Visible = false;
            this.pctbx1.Click += new System.EventHandler(this.KlikkenKaart);
            // 
            // lblTitleScreen
            // 
            this.lblTitleScreen.AutoSize = true;
            this.lblTitleScreen.Enabled = false;
            this.lblTitleScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleScreen.Location = new System.Drawing.Point(289, 194);
            this.lblTitleScreen.Name = "lblTitleScreen";
            this.lblTitleScreen.Size = new System.Drawing.Size(514, 69);
            this.lblTitleScreen.TabIndex = 29;
            this.lblTitleScreen.Text = "MEMORRYYYY!!!";
            this.lblTitleScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBeginSpel
            // 
            this.btnBeginSpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginSpel.Location = new System.Drawing.Point(441, 287);
            this.btnBeginSpel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeginSpel.Name = "btnBeginSpel";
            this.btnBeginSpel.Size = new System.Drawing.Size(176, 47);
            this.btnBeginSpel.TabIndex = 30;
            this.btnBeginSpel.Text = "Begin spel!";
            this.btnBeginSpel.UseVisualStyleBackColor = true;
            this.btnBeginSpel.Click += new System.EventHandler(this.InitialiserenScherm);
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1056, 603);
            this.Controls.Add(this.btnBeginSpel);
            this.Controls.Add(this.lblTitleScreen);
            this.Controls.Add(this.lblScorePlayer2);
            this.Controls.Add(this.lblScorePlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pctbx12);
            this.Controls.Add(this.pctbx17);
            this.Controls.Add(this.pctbx18);
            this.Controls.Add(this.pctbx19);
            this.Controls.Add(this.pctbx20);
            this.Controls.Add(this.pctbx13);
            this.Controls.Add(this.pctbx14);
            this.Controls.Add(this.pctbx15);
            this.Controls.Add(this.pctbx16);
            this.Controls.Add(this.pctbx9);
            this.Controls.Add(this.pctbx10);
            this.Controls.Add(this.pctbx11);
            this.Controls.Add(this.pctbx5);
            this.Controls.Add(this.pctbx6);
            this.Controls.Add(this.pctbx7);
            this.Controls.Add(this.pctbx8);
            this.Controls.Add(this.pctbx4);
            this.Controls.Add(this.pctbx3);
            this.Controls.Add(this.pctbx2);
            this.Controls.Add(this.pctbx1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = new Icon("fotos/icon/ProgrammaIcon.ico");
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoryGame";
            this.Text = "Memory game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNieuwSpel;
        private System.Windows.Forms.PictureBox pctbx1;
        private System.Windows.Forms.PictureBox pctbx2;
        private System.Windows.Forms.PictureBox pctbx3;
        private System.Windows.Forms.PictureBox pctbx4;
        private System.Windows.Forms.PictureBox pctbx5;
        private System.Windows.Forms.PictureBox pctbx6;
        private System.Windows.Forms.PictureBox pctbx7;
        private System.Windows.Forms.PictureBox pctbx8;
        private System.Windows.Forms.PictureBox pctbx9;
        private System.Windows.Forms.PictureBox pctbx10;
        private System.Windows.Forms.PictureBox pctbx11;
        private System.Windows.Forms.PictureBox pctbx13;
        private System.Windows.Forms.PictureBox pctbx14;
        private System.Windows.Forms.PictureBox pctbx15;
        private System.Windows.Forms.PictureBox pctbx16;
        private System.Windows.Forms.PictureBox pctbx17;
        private System.Windows.Forms.PictureBox pctbx18;
        private System.Windows.Forms.PictureBox pctbx19;
        private System.Windows.Forms.PictureBox pctbx20;
        private System.Windows.Forms.PictureBox pctbx12;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Label lblScorePlayer1;
        private System.Windows.Forms.Label lblTitleScreen;
        private System.Windows.Forms.Button btnBeginSpel;
    }
}

