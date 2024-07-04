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
    public partial class Minesweeper : Form
    {
        int score = 0;
        PictureBox[] tiles = new PictureBox[100];
        public Minesweeper()
        {
            InitializeComponent();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            load_tiles();
        }

        private void load_tiles()
        {
            int x = 0;
            int y = 0;
            int cnt = 0;
            Random random = new Random();

            for(int i = 0; i< 100; i++)
            {
                int num = random.Next(0, 2);
                tiles[i] = new PictureBox();
                tiles[i].Height = 40;
                tiles[i].Width = 40;
                tiles[i].Left = x;
                tiles[i].Top = y;
                tiles[i].BorderStyle = BorderStyle.FixedSingle;
                tiles[i].Image = imageList1.Images[2];
                if (num == 0)
                {
                    tiles[i].Tag = "Bomb";
                }
                else
                {
                    tiles[i].Tag = "Dollar";
                }
                tiles[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tiles[i].Click += new System.EventHandler(ClickTile);
                panel1.Controls.Add(tiles[i]);
                x = x + 40;
                cnt++;
                if (cnt == 10)
                {
                    x = 0;
                    y = y + 40;
                    cnt = 0;
                }
            }
        }

        private void ClickTile(Object sender, System.EventArgs e)
        {
            DialogResult dg;
            PictureBox tile2 = (PictureBox)sender;

            if(tile2.Tag.ToString() != "Clicked")
            {
                if (tile2.Tag.ToString() == "Bomb")
                {
                    tile2.Image = imageList1.Images[0];
                    dg = MessageBox.Show("Game Over!, Your Score: " + score.ToString() + "\nPlay Again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        score = 0;
                        lbScore.Text = "0";
                        foreach (PictureBox tile in tiles)
                        {
                            panel1.Controls.Remove(tile);
                        }
                        load_tiles();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (tile2.Tag.ToString() == "Dollar")
                {
                    tile2.Image = imageList1.Images[1];
                    tile2.Tag = "Clicked";
                    score += 5;
                    lbScore.Text = score.ToString();
                }
            }

        }
    }
}
