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
            this.btnMinesweeper = new System.Windows.Forms.Button();
            this.btnDino = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 466);
            this.Controls.Add(this.btnDino);
            this.Controls.Add(this.btnMinesweeper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinesweeper;
        private System.Windows.Forms.Button btnDino;
    }
}

