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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStartButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // WumpusStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(933, 519);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxStartButton);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "WumpusStart";
            Text = "Escape The Wumpus";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStartButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxStartButton;
        private PictureBox pictureBox1;
    }
}