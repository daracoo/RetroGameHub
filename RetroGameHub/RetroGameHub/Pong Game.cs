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
    public partial class Pong_Game : Form
    {
        int ballXSpeed = 4;
        int ballYSpeed = 4;
        int speed = 2;
        Random random = new Random();
        bool goDown, goUp;
        int computer_speed_change = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };

        public Pong_Game()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void Pong_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        private void Pong_Game_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {

        }

        private void GameOver(string message)
        {

        }
    }
}
