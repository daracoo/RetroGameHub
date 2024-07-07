using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroGameHub
{
    public partial class T_Rex : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random random = new Random();
        int position;
        bool isGameOver = false;

        public T_Rex()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            tRex.Top += jumpSpeed;
            lblScore.Text = "Score: " + score;
            if(jumping == true && force < 0)
            {
                jumping = false;
            }

            if(jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if(tRex.Top > 291 && jumping == false)
            {
                force = 12;
                tRex.Top = 292;
                jumpSpeed = 0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if(x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200, 500) + (x.Width * 15);
                        score++;
                    }
                    if (tRex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        tRex.Image = Properties.Resources.dead;
                        lblScore.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }

            if(score > 10)
            {
                obstacleSpeed = 15;
            }
        }

        private void T_Rex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void T_Rex_KeyUp(object sender, KeyEventArgs e)
        {
            if(jumping == true)
            {
                jumping = false;
            }
            if(e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            lblScore.Text = "Score: " + score;
            tRex.Image = Properties.Resources.running;
            isGameOver = false;
            tRex.Top = 292;
            
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 0);             
                    x.Left = position;
                }
            }

            gameTimer.Start();


        }
    }
}
