using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game_2
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        int ballSpeed = 3;
        int ballX = 1;
        int ballY = 1;
        int points = 0;
        int lives = 5;
        int bricksLeft = 20;
        int currentLevel = 1;
        int pointsNewLife = 0;
        bool paused = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)  // makes it so when you click the start button, it removes the button and starts the timer
        {
            setLives(5);
            showPoints();
            GameTimer.Enabled = true;
            startbutton.Visible = false;
            panelEndGame.Visible = false;
            resetGame();
        }

        private void resetGame()
        {
            
            Color[] colors = { Color.Blue, Color.Red, Color.Purple, Color.Pink, Color.Orange, Color.Green };    // sets all the blocks to a random colour

            foreach (Control p in this.Controls)
            {
                if (p is PictureBox && (string)p.Tag == "Block")
                {
                    p.BackColor = colors[rand.Next(colors.Length)];
                    p.Visible = true;
                    
                }
            }
            if (lives <= 0)
            {
                panelEndGame.Visible = true;
                labelTotalPoints.Text = "Total Points: " + points;
                startbutton.Visible = true;
                bricksLeft = 20;
                points = 0;
            }

            else
            
            if (bricksLeft == 0)
            {
                bricksLeft = 20;
                GameTimer.Enabled = false;
                currentLevel++;
                labelPointsNewLevel.Text = "Points: " + points;
                labelCongratsNewLevel.Text = "Congratulations you \n have reached level " + currentLevel;
                panelNewLevel.Visible = true;
                buttonNextLevel.Visible = true;
            }
            resetBall();


        }

        private void setLives(int lives)
        {

            this.lives = lives; //this.lives refers to the global variable and lives is the local variable
            labelLives.Text = "Lives: " + lives;
        }

        private void showPoints()
        {
            labelPoints.Text = "Points: " + points;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetBall();

        }

        private void resetBall()       //centres ball
        {
            ballX = rand.Next(0, 2) * 2 - 1;
            ballY = rand.Next(0, 2) * 2 - 1;
            Ball.Left = (ClientRectangle.Width / 2) - (Ball.Width / 2);
            Ball.Top = (ClientRectangle.Height /2) - (Ball.Height / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control p in this.Controls)            //ball collision with block
            {
                if (p is PictureBox && (string)p.Tag == "Block" || (string)p.Tag == "Red")
                {
                    if (Ball.Bounds.IntersectsWith(p.Bounds) && p.Visible == true)
                    {
                        if (p.Left > (Ball.Left + Ball.Width - ballSpeed) || (p.Left + p.Width - ballSpeed) < Ball.Left)
                        {
                            ballX = -ballX;
                        }
                        else
                        {
                            ballY = -ballY;
                        }
                        p.Visible = false;

                        addPoints(p.BackColor);
                        bricksLeft--;
                        break;
                    }
                }
            }
            Ball.Left = Ball.Left + ballSpeed * ballX;      //ball movement
            Ball.Top = Ball.Top + ballSpeed * ballY;

            if (Ball.Left < 0 || Ball.Left > ClientRectangle.Width - Ball.Width)        //ball collision with the edges
                ballX = -ballX;

            if (Ball.Top < 0 || Ball.Top > ClientRectangle.Height - Ball.Height)
                ballY = -ballY;

            if (Ball.Top + Ball.Height >= ClientRectangle.Height)
            {
                setLives(lives - 1);
                GameTimer.Enabled = false;

                
                
                if(lives == 0) // resets game after dying
                {
                    resetGame();
                }
                else
                {
                    buttonKeepGoing.Visible = true;
                    resetBall();
                }
            }

            if (Ball.Bounds.IntersectsWith(paddle.Bounds))
                {
                ballY = -1;
                }

            if (bricksLeft == 0)    //resets game when a level is completed
            {
                resetGame();
            }
        }

        private void addPoints(Color color) //adds points based on whether the ball hit a normal brick or a red brick
        {

            if (color.Equals(Color.Red)) // gives 20 points for red brick
            {
                points += 20;
                pointsNewLife += 20;
            }
            else
            {
                points += 10; // gives 10 points for any other color brick
                pointsNewLife += 10;
            }

            while (pointsNewLife >= 100) //gives a new life for every 100 points gained
            {
                setLives(lives + 1);
                pointsNewLife = 0;
            }
            showPoints();
        }

        private void PaddleMove(object sender, MouseEventArgs e) //moves paddle using the mouse
        {
            int newPos = e.X - paddle.Width / 2;

            if(paused == false)//pauses the paddle when "esc" is clicked
            {
                if (newPos < 0)
                {
                    newPos = 0;
                }

                if (newPos > ClientSize.Width - paddle.Width)
                {
                    newPos = ClientSize.Width - paddle.Width;
                }

                paddle.Left = newPos;
            }

        }

        private void buttonKeepGoing_Click(object sender, EventArgs e) //continues the game after dying
        {
            GameTimer.Enabled = true;
            buttonKeepGoing.Visible = false;
        }

        private void buttonNextLevel_Click(object sender, EventArgs e) //starts next level
        {
            GameTimer.Enabled = true;
            buttonNextLevel.Visible = false;
            panelNewLevel.Visible = false;
            resetGame();
        }

        private void buttonInsertCoin_Click(object sender, EventArgs e) //displays full game
        {
            panelStartScreen.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //pauses the game when "esc" is clicked
        {
                if (keyData == Keys.Escape && GameTimer.Enabled == true) //ensures the game timer is enabled before you can pause
                    {
                        panelPaused.Visible = true;
                        GameTimer.Enabled = false;
                        paused = true;
                    }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonResume_Click(object sender, EventArgs e) //resumes the game
        {
            paused = false;
            GameTimer.Enabled = true;
            panelPaused.Visible = false;
        }
    }
}
