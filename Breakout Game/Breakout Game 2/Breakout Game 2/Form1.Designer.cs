namespace Breakout_Game_2
{
    partial class Form1
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
            this.startbutton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelLives = new System.Windows.Forms.Label();
            this.panelEndGame = new System.Windows.Forms.Panel();
            this.labelTotalPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeepGoing = new System.Windows.Forms.Button();
            this.panelNewLevel = new System.Windows.Forms.Panel();
            this.labelPointsNewLevel = new System.Windows.Forms.Label();
            this.labelCongratsNewLevel = new System.Windows.Forms.Label();
            this.buttonNextLevel = new System.Windows.Forms.Button();
            this.panelStartScreen = new System.Windows.Forms.Panel();
            this.buttonInsertCoin = new System.Windows.Forms.Button();
            this.panelPaused = new System.Windows.Forms.Panel();
            this.buttonResume = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.block18 = new System.Windows.Forms.PictureBox();
            this.block19 = new System.Windows.Forms.PictureBox();
            this.block20 = new System.Windows.Forms.PictureBox();
            this.block12 = new System.Windows.Forms.PictureBox();
            this.block13 = new System.Windows.Forms.PictureBox();
            this.block14 = new System.Windows.Forms.PictureBox();
            this.block15 = new System.Windows.Forms.PictureBox();
            this.block16 = new System.Windows.Forms.PictureBox();
            this.block17 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block5 = new System.Windows.Forms.PictureBox();
            this.block6 = new System.Windows.Forms.PictureBox();
            this.block7 = new System.Windows.Forms.PictureBox();
            this.block8 = new System.Windows.Forms.PictureBox();
            this.block9 = new System.Windows.Forms.PictureBox();
            this.block10 = new System.Windows.Forms.PictureBox();
            this.block11 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.panelEndGame.SuspendLayout();
            this.panelNewLevel.SuspendLayout();
            this.panelStartScreen.SuspendLayout();
            this.panelPaused.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(225, 318);
            this.startbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(109, 43);
            this.startbutton.TabIndex = 23;
            this.startbutton.Text = "Start Game";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 15;
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPoints.Location = new System.Drawing.Point(17, 457);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(63, 17);
            this.labelPoints.TabIndex = 25;
            this.labelPoints.Text = "Points: 0";
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.ForeColor = System.Drawing.Color.White;
            this.labelLives.Location = new System.Drawing.Point(495, 457);
            this.labelLives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(57, 17);
            this.labelLives.TabIndex = 26;
            this.labelLives.Text = "Lives: 0";
            // 
            // panelEndGame
            // 
            this.panelEndGame.BackColor = System.Drawing.Color.Red;
            this.panelEndGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEndGame.Controls.Add(this.labelTotalPoints);
            this.panelEndGame.Controls.Add(this.label1);
            this.panelEndGame.Location = new System.Drawing.Point(76, 156);
            this.panelEndGame.Margin = new System.Windows.Forms.Padding(4);
            this.panelEndGame.Name = "panelEndGame";
            this.panelEndGame.Size = new System.Drawing.Size(407, 160);
            this.panelEndGame.TabIndex = 27;
            this.panelEndGame.Visible = false;
            // 
            // labelTotalPoints
            // 
            this.labelTotalPoints.AutoSize = true;
            this.labelTotalPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalPoints.Location = new System.Drawing.Point(147, 105);
            this.labelTotalPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPoints.Name = "labelTotalPoints";
            this.labelTotalPoints.Size = new System.Drawing.Size(91, 17);
            this.labelTotalPoints.TabIndex = 1;
            this.labelTotalPoints.Text = "Total Points: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Died!";
            // 
            // buttonKeepGoing
            // 
            this.buttonKeepGoing.Location = new System.Drawing.Point(225, 318);
            this.buttonKeepGoing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeepGoing.Name = "buttonKeepGoing";
            this.buttonKeepGoing.Size = new System.Drawing.Size(109, 43);
            this.buttonKeepGoing.TabIndex = 28;
            this.buttonKeepGoing.Text = "Keep Going!";
            this.buttonKeepGoing.UseVisualStyleBackColor = true;
            this.buttonKeepGoing.Visible = false;
            this.buttonKeepGoing.Click += new System.EventHandler(this.buttonKeepGoing_Click);
            // 
            // panelNewLevel
            // 
            this.panelNewLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelNewLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNewLevel.Controls.Add(this.labelPointsNewLevel);
            this.panelNewLevel.Controls.Add(this.labelCongratsNewLevel);
            this.panelNewLevel.Location = new System.Drawing.Point(76, 156);
            this.panelNewLevel.Margin = new System.Windows.Forms.Padding(4);
            this.panelNewLevel.Name = "panelNewLevel";
            this.panelNewLevel.Size = new System.Drawing.Size(407, 160);
            this.panelNewLevel.TabIndex = 28;
            this.panelNewLevel.Visible = false;
            // 
            // labelPointsNewLevel
            // 
            this.labelPointsNewLevel.AutoSize = true;
            this.labelPointsNewLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsNewLevel.Location = new System.Drawing.Point(149, 110);
            this.labelPointsNewLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPointsNewLevel.Name = "labelPointsNewLevel";
            this.labelPointsNewLevel.Size = new System.Drawing.Size(101, 17);
            this.labelPointsNewLevel.TabIndex = 1;
            this.labelPointsNewLevel.Text = "Points So Far: ";
            // 
            // labelCongratsNewLevel
            // 
            this.labelCongratsNewLevel.AutoSize = true;
            this.labelCongratsNewLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCongratsNewLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCongratsNewLevel.Location = new System.Drawing.Point(37, 18);
            this.labelCongratsNewLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCongratsNewLevel.Name = "labelCongratsNewLevel";
            this.labelCongratsNewLevel.Size = new System.Drawing.Size(329, 78);
            this.labelCongratsNewLevel.TabIndex = 0;
            this.labelCongratsNewLevel.Text = "Congratulations you \r\nhave reached level ";
            this.labelCongratsNewLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonNextLevel
            // 
            this.buttonNextLevel.Location = new System.Drawing.Point(225, 318);
            this.buttonNextLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextLevel.Name = "buttonNextLevel";
            this.buttonNextLevel.Size = new System.Drawing.Size(109, 43);
            this.buttonNextLevel.TabIndex = 29;
            this.buttonNextLevel.Text = "Next Level";
            this.buttonNextLevel.UseVisualStyleBackColor = true;
            this.buttonNextLevel.Visible = false;
            this.buttonNextLevel.Click += new System.EventHandler(this.buttonNextLevel_Click);
            // 
            // panelStartScreen
            // 
            this.panelStartScreen.Controls.Add(this.buttonInsertCoin);
            this.panelStartScreen.Controls.Add(this.pictureBox1);
            this.panelStartScreen.Controls.Add(this.pictureBox2);
            this.panelStartScreen.Location = new System.Drawing.Point(0, 0);
            this.panelStartScreen.Name = "panelStartScreen";
            this.panelStartScreen.Size = new System.Drawing.Size(570, 489);
            this.panelStartScreen.TabIndex = 30;
            // 
            // buttonInsertCoin
            // 
            this.buttonInsertCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonInsertCoin.Location = new System.Drawing.Point(197, 300);
            this.buttonInsertCoin.Name = "buttonInsertCoin";
            this.buttonInsertCoin.Size = new System.Drawing.Size(159, 73);
            this.buttonInsertCoin.TabIndex = 0;
            this.buttonInsertCoin.Text = "Insert £1 Coin";
            this.buttonInsertCoin.UseVisualStyleBackColor = true;
            this.buttonInsertCoin.Click += new System.EventHandler(this.buttonInsertCoin_Click);
            // 
            // panelPaused
            // 
            this.panelPaused.BackColor = System.Drawing.Color.DarkBlue;
            this.panelPaused.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPaused.Controls.Add(this.buttonResume);
            this.panelPaused.Controls.Add(this.label4);
            this.panelPaused.Location = new System.Drawing.Point(76, 156);
            this.panelPaused.Margin = new System.Windows.Forms.Padding(4);
            this.panelPaused.Name = "panelPaused";
            this.panelPaused.Size = new System.Drawing.Size(407, 160);
            this.panelPaused.TabIndex = 29;
            this.panelPaused.Visible = false;
            // 
            // buttonResume
            // 
            this.buttonResume.Location = new System.Drawing.Point(166, 104);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(75, 23);
            this.buttonResume.TabIndex = 1;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(88, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Game Paused";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Breakout_Game_2.Properties.Resources.Breakout_Sub_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(173, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Breakout_Game_2.Properties.Resources.Breakout_Logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(128, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.Control;
            this.paddle.Location = new System.Drawing.Point(235, 441);
            this.paddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(85, 20);
            this.paddle.TabIndex = 22;
            this.paddle.TabStop = false;
            this.paddle.Tag = "";
            // 
            // block18
            // 
            this.block18.Location = new System.Drawing.Point(235, 121);
            this.block18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block18.Name = "block18";
            this.block18.Size = new System.Drawing.Size(100, 30);
            this.block18.TabIndex = 21;
            this.block18.TabStop = false;
            this.block18.Tag = "Block";
            // 
            // block19
            // 
            this.block19.Location = new System.Drawing.Point(340, 121);
            this.block19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block19.Name = "block19";
            this.block19.Size = new System.Drawing.Size(100, 30);
            this.block19.TabIndex = 20;
            this.block19.TabStop = false;
            this.block19.Tag = "Block";
            // 
            // block20
            // 
            this.block20.Location = new System.Drawing.Point(445, 121);
            this.block20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block20.Name = "block20";
            this.block20.Size = new System.Drawing.Size(100, 30);
            this.block20.TabIndex = 19;
            this.block20.TabStop = false;
            this.block20.Tag = "Block";
            // 
            // block12
            // 
            this.block12.Location = new System.Drawing.Point(128, 84);
            this.block12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block12.Name = "block12";
            this.block12.Size = new System.Drawing.Size(100, 30);
            this.block12.TabIndex = 18;
            this.block12.TabStop = false;
            this.block12.Tag = "Block";
            // 
            // block13
            // 
            this.block13.Location = new System.Drawing.Point(235, 84);
            this.block13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block13.Name = "block13";
            this.block13.Size = new System.Drawing.Size(100, 30);
            this.block13.TabIndex = 17;
            this.block13.TabStop = false;
            this.block13.Tag = "Block";
            // 
            // block14
            // 
            this.block14.Location = new System.Drawing.Point(340, 84);
            this.block14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block14.Name = "block14";
            this.block14.Size = new System.Drawing.Size(100, 30);
            this.block14.TabIndex = 16;
            this.block14.TabStop = false;
            this.block14.Tag = "Block";
            // 
            // block15
            // 
            this.block15.Location = new System.Drawing.Point(445, 84);
            this.block15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block15.Name = "block15";
            this.block15.Size = new System.Drawing.Size(100, 30);
            this.block15.TabIndex = 15;
            this.block15.TabStop = false;
            this.block15.Tag = "Block";
            // 
            // block16
            // 
            this.block16.Location = new System.Drawing.Point(21, 121);
            this.block16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block16.Name = "block16";
            this.block16.Size = new System.Drawing.Size(100, 30);
            this.block16.TabIndex = 14;
            this.block16.TabStop = false;
            this.block16.Tag = "Block";
            // 
            // block17
            // 
            this.block17.Location = new System.Drawing.Point(128, 121);
            this.block17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block17.Name = "block17";
            this.block17.Size = new System.Drawing.Size(100, 30);
            this.block17.TabIndex = 13;
            this.block17.TabStop = false;
            this.block17.Tag = "Block";
            // 
            // block2
            // 
            this.block2.Location = new System.Drawing.Point(128, 12);
            this.block2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(100, 30);
            this.block2.TabIndex = 12;
            this.block2.TabStop = false;
            this.block2.Tag = "Block";
            // 
            // block3
            // 
            this.block3.Location = new System.Drawing.Point(235, 12);
            this.block3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(100, 30);
            this.block3.TabIndex = 11;
            this.block3.TabStop = false;
            this.block3.Tag = "Block";
            // 
            // block4
            // 
            this.block4.Location = new System.Drawing.Point(340, 12);
            this.block4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(100, 30);
            this.block4.TabIndex = 10;
            this.block4.TabStop = false;
            this.block4.Tag = "Block";
            // 
            // block5
            // 
            this.block5.Location = new System.Drawing.Point(445, 12);
            this.block5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(100, 30);
            this.block5.TabIndex = 9;
            this.block5.TabStop = false;
            this.block5.Tag = "Block";
            // 
            // block6
            // 
            this.block6.Location = new System.Drawing.Point(21, 48);
            this.block6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(100, 30);
            this.block6.TabIndex = 8;
            this.block6.TabStop = false;
            this.block6.Tag = "Block";
            // 
            // block7
            // 
            this.block7.Location = new System.Drawing.Point(128, 48);
            this.block7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(100, 30);
            this.block7.TabIndex = 7;
            this.block7.TabStop = false;
            this.block7.Tag = "Block";
            // 
            // block8
            // 
            this.block8.Location = new System.Drawing.Point(235, 48);
            this.block8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(100, 30);
            this.block8.TabIndex = 6;
            this.block8.TabStop = false;
            this.block8.Tag = "Block";
            // 
            // block9
            // 
            this.block9.Location = new System.Drawing.Point(340, 48);
            this.block9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block9.Name = "block9";
            this.block9.Size = new System.Drawing.Size(100, 30);
            this.block9.TabIndex = 5;
            this.block9.TabStop = false;
            this.block9.Tag = "Block";
            // 
            // block10
            // 
            this.block10.BackColor = System.Drawing.Color.Black;
            this.block10.Location = new System.Drawing.Point(445, 48);
            this.block10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block10.Name = "block10";
            this.block10.Size = new System.Drawing.Size(100, 30);
            this.block10.TabIndex = 4;
            this.block10.TabStop = false;
            this.block10.Tag = "Block";
            // 
            // block11
            // 
            this.block11.Location = new System.Drawing.Point(21, 84);
            this.block11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block11.Name = "block11";
            this.block11.Size = new System.Drawing.Size(100, 30);
            this.block11.TabIndex = 3;
            this.block11.TabStop = false;
            this.block11.Tag = "Block";
            // 
            // block1
            // 
            this.block1.Location = new System.Drawing.Point(21, 12);
            this.block1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(100, 30);
            this.block1.TabIndex = 0;
            this.block1.TabStop = false;
            this.block1.Tag = "Block";
            // 
            // Ball
            // 
            this.Ball.BackgroundImage = global::Breakout_Game_2.Properties.Resources.Ball;
            this.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ball.Location = new System.Drawing.Point(510, 251);
            this.Ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 24;
            this.Ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(569, 487);
            this.Controls.Add(this.panelStartScreen);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.block18);
            this.Controls.Add(this.block19);
            this.Controls.Add(this.block20);
            this.Controls.Add(this.block12);
            this.Controls.Add(this.block13);
            this.Controls.Add(this.block14);
            this.Controls.Add(this.block15);
            this.Controls.Add(this.block16);
            this.Controls.Add(this.block17);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block3);
            this.Controls.Add(this.block4);
            this.Controls.Add(this.block5);
            this.Controls.Add(this.block6);
            this.Controls.Add(this.block7);
            this.Controls.Add(this.block8);
            this.Controls.Add(this.block9);
            this.Controls.Add(this.block10);
            this.Controls.Add(this.block11);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.panelEndGame);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.buttonNextLevel);
            this.Controls.Add(this.buttonKeepGoing);
            this.Controls.Add(this.panelPaused);
            this.Controls.Add(this.panelNewLevel);
            this.Controls.Add(this.Ball);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaddleMove);
            this.panelEndGame.ResumeLayout(false);
            this.panelEndGame.PerformLayout();
            this.panelNewLevel.ResumeLayout(false);
            this.panelNewLevel.PerformLayout();
            this.panelStartScreen.ResumeLayout(false);
            this.panelPaused.ResumeLayout(false);
            this.panelPaused.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block11;
        private System.Windows.Forms.PictureBox block10;
        private System.Windows.Forms.PictureBox block9;
        private System.Windows.Forms.PictureBox block8;
        private System.Windows.Forms.PictureBox block7;
        private System.Windows.Forms.PictureBox block6;
        private System.Windows.Forms.PictureBox block5;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block17;
        private System.Windows.Forms.PictureBox block16;
        private System.Windows.Forms.PictureBox block15;
        private System.Windows.Forms.PictureBox block14;
        private System.Windows.Forms.PictureBox block13;
        private System.Windows.Forms.PictureBox block12;
        private System.Windows.Forms.PictureBox block20;
        private System.Windows.Forms.PictureBox block19;
        private System.Windows.Forms.PictureBox block18;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.Panel panelEndGame;
        private System.Windows.Forms.Label labelTotalPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeepGoing;
        private System.Windows.Forms.Panel panelNewLevel;
        private System.Windows.Forms.Label labelPointsNewLevel;
        private System.Windows.Forms.Label labelCongratsNewLevel;
        private System.Windows.Forms.Button buttonNextLevel;
        private System.Windows.Forms.Panel panelStartScreen;
        private System.Windows.Forms.Button buttonInsertCoin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelPaused;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Label label4;
    }
}

