﻿using System;
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
    }
}