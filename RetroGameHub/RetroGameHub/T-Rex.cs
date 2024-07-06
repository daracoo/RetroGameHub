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
        int jumpSpeed = 12;
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

        }

        private void T_Rex_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void T_Rex_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void GameReset()
        {
            force = 12;
        }
    }
}
