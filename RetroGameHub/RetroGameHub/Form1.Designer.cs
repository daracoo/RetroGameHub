namespace RetroGameHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMinesweeper = new System.Windows.Forms.Button();
            this.btnDino = new System.Windows.Forms.Button();
            this.btnPong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMinesweeper
            // 
            this.btnMinesweeper.Location = new System.Drawing.Point(141, 159);
            this.btnMinesweeper.Name = "btnMinesweeper";
            this.btnMinesweeper.Size = new System.Drawing.Size(148, 41);
            this.btnMinesweeper.TabIndex = 0;
            this.btnMinesweeper.Text = "Minesweeper";
            this.btnMinesweeper.UseVisualStyleBackColor = true;
            this.btnMinesweeper.Click += new System.EventHandler(this.btnMinesweeper_Click);
            // 
            // btnDino
            // 
            this.btnDino.Location = new System.Drawing.Point(141, 243);
            this.btnDino.Name = "btnDino";
            this.btnDino.Size = new System.Drawing.Size(148, 41);
            this.btnDino.TabIndex = 1;
            this.btnDino.Text = "T-Rex";
            this.btnDino.UseVisualStyleBackColor = true;
            this.btnDino.Click += new System.EventHandler(this.btnDino_Click);
            // 
            // btnPong
            // 
            this.btnPong.Location = new System.Drawing.Point(141, 323);
            this.btnPong.Name = "btnPong";
            this.btnPong.Size = new System.Drawing.Size(148, 41);
            this.btnPong.TabIndex = 2;
            this.btnPong.Text = "Pong";
            this.btnPong.UseVisualStyleBackColor = true;
            this.btnPong.Click += new System.EventHandler(this.btnPong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose What to Play:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Made by daraco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::RetroGameHub.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(434, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPong);
            this.Controls.Add(this.btnDino);
            this.Controls.Add(this.btnMinesweeper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Retro Game Hub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinesweeper;
        private System.Windows.Forms.Button btnDino;
        private System.Windows.Forms.Button btnPong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

