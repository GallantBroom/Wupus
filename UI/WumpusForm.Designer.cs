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
            labelHunt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStartButton).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxStartButton
            // 
            pictureBoxStartButton.BackColor = SystemColors.ControlLightLight;
            pictureBoxStartButton.BackgroundImageLayout = ImageLayout.None;
            pictureBoxStartButton.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxStartButton.Image = (Image)resources.GetObject("pictureBoxStartButton.Image");
            pictureBoxStartButton.Location = new Point(359, 356);
            pictureBoxStartButton.Name = "pictureBoxStartButton";
            pictureBoxStartButton.Size = new Size(199, 70);
            pictureBoxStartButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStartButton.TabIndex = 0;
            pictureBoxStartButton.TabStop = false;
            pictureBoxStartButton.Click += pictureBoxStartButton_Click;
            // 
            // labelHunt
            // 
            labelHunt.AutoSize = true;
            labelHunt.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHunt.Location = new Point(228, 117);
            labelHunt.Name = "labelHunt";
            labelHunt.Size = new Size(485, 57);
            labelHunt.TabIndex = 1;
            labelHunt.Text = "Hunt The Wumpus";
            // 
            // WumpusStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(933, 519);
            Controls.Add(labelHunt);
            Controls.Add(pictureBoxStartButton);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "WumpusStart";
            Text = "Escape The Wumpus";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStartButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxStartButton;
        private Label labelHunt;
    }
}