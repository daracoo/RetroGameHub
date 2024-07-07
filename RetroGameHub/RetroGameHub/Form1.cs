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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnMinesweeper.UseVisualStyleBackColor = true;
            this.btnDino.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinesweeper_Click(object sender, EventArgs e)
        {
            Minesweeper minesweeper = new Minesweeper();
            minesweeper.Show();
        }

        private void btnDino_Click(object sender, EventArgs e)
        {
            T_Rex trex = new T_Rex();
            trex.Show();
        }

        private void btnPong_Click(object sender, EventArgs e)
        {
            Pong_Game pongGame = new Pong_Game();
            pongGame.Show();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            Memory_Game memoryGame = new Memory_Game();
            memoryGame.Show();
        }
    }
}
