namespace UI
{
    partial class WumpusForm
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelTitleCave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(203, 152);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(272, 31);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Cave 1";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cave 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cave 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(203, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cave 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(203, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cave 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelTitleCave
            // 
            this.labelTitleCave.AutoSize = true;
            this.labelTitleCave.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCave.Location = new System.Drawing.Point(182, 50);
            this.labelTitleCave.Name = "labelTitleCave";
            this.labelTitleCave.Size = new System.Drawing.Size(357, 55);
            this.labelTitleCave.TabIndex = 5;
            this.labelTitleCave.Text = "Choose a Cave";
            // 
            // WumpusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitleCave);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "WumpusForm";
            this.Text = "Escape The Wumpus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelTitleCave;
    }
}

