namespace UI
{
    partial class WumpusStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WumpusStart));
            pictureBoxStartButton = new PictureBox();
            pictureBoxHighScore = new PictureBox();
            pictureBoxQuit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStartButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHighScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuit).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxStartButton
            // 
            pictureBoxStartButton.BackColor = SystemColors.ControlLightLight;
            pictureBoxStartButton.BackgroundImageLayout = ImageLayout.None;
            pictureBoxStartButton.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxStartButton.Image = (Image)resources.GetObject("pictureBoxStartButton.Image");
            pictureBoxStartButton.Location = new Point(380, 137);
            pictureBoxStartButton.Name = "pictureBoxStartButton";
            pictureBoxStartButton.Size = new Size(108, 45);
            pictureBoxStartButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStartButton.TabIndex = 0;
            pictureBoxStartButton.TabStop = false;
            pictureBoxStartButton.Click += pictureBoxStartButton_Click;
            // 
            // pictureBoxHighScore
            // 
            pictureBoxHighScore.BackColor = SystemColors.ControlLightLight;
            pictureBoxHighScore.BackgroundImageLayout = ImageLayout.None;
            pictureBoxHighScore.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHighScore.Image = (Image)resources.GetObject("pictureBoxHighScore.Image");
            pictureBoxHighScore.Location = new Point(380, 213);
            pictureBoxHighScore.Name = "pictureBoxHighScore";
            pictureBoxHighScore.Size = new Size(108, 45);
            pictureBoxHighScore.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHighScore.TabIndex = 1;
            pictureBoxHighScore.TabStop = false;
            pictureBoxHighScore.Click += pictureBox1_Click;
            // 
            // pictureBoxQuit
            // 
            pictureBoxQuit.BackColor = SystemColors.ControlLightLight;
            pictureBoxQuit.BackgroundImageLayout = ImageLayout.None;
            pictureBoxQuit.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxQuit.Image = (Image)resources.GetObject("pictureBoxQuit.Image");
            pictureBoxQuit.Location = new Point(380, 302);
            pictureBoxQuit.Name = "pictureBoxQuit";
            pictureBoxQuit.Size = new Size(108, 45);
            pictureBoxQuit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQuit.TabIndex = 2;
            pictureBoxQuit.TabStop = false;
            pictureBoxQuit.Click += pictureBoxQuit_Click;
            // 
            // WumpusStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(933, 519);
            Controls.Add(pictureBoxQuit);
            Controls.Add(pictureBoxHighScore);
            Controls.Add(pictureBoxStartButton);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "WumpusStart";
            Text = "Escape The Wumpus";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStartButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHighScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxStartButton;
        private PictureBox pictureBoxHighScore;
        private PictureBox pictureBoxQuit;
    }
}