namespace UI
{
    partial class Main
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
            buttonNorthEast = new Button();
            buttonSouthWest = new Button();
            buttonNorthWest = new Button();
            buttonSouthEast = new Button();
            buttonEast = new Button();
            buttonWest = new Button();
            labelHints = new Label();
            labelArrows = new Label();
            labelGold = new Label();
            labelGoldAmount = new Label();
            labelArrowAmount = new Label();
            buttonShop = new Button();
            labelScoreAmount = new Label();
            labelScore = new Label();
            pictureBox1 = new PictureBox();
            labelHint3 = new Label();
            labelHint2 = new Label();
            labelAlerts = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonNorthEast
            // 
            buttonNorthEast.Enabled = false;
            buttonNorthEast.Location = new Point(98, 12);
            buttonNorthEast.Name = "buttonNorthEast";
            buttonNorthEast.Size = new Size(85, 52);
            buttonNorthEast.TabIndex = 0;
            buttonNorthEast.Text = "NorthEast";
            buttonNorthEast.UseVisualStyleBackColor = true;
            buttonNorthEast.Click += buttonNorthEast_Click;
            // 
            // buttonSouthWest
            // 
            buttonSouthWest.Enabled = false;
            buttonSouthWest.Location = new Point(12, 117);
            buttonSouthWest.Name = "buttonSouthWest";
            buttonSouthWest.Size = new Size(80, 23);
            buttonSouthWest.TabIndex = 1;
            buttonSouthWest.Text = "SouthWest";
            buttonSouthWest.UseVisualStyleBackColor = true;
            buttonSouthWest.Click += buttonSouthWest_Click;
            // 
            // buttonNorthWest
            // 
            buttonNorthWest.Enabled = false;
            buttonNorthWest.Location = new Point(12, 12);
            buttonNorthWest.Name = "buttonNorthWest";
            buttonNorthWest.Size = new Size(80, 52);
            buttonNorthWest.TabIndex = 2;
            buttonNorthWest.Text = "NorthWest";
            buttonNorthWest.UseVisualStyleBackColor = true;
            buttonNorthWest.Click += buttonNorthWest_Click;
            // 
            // buttonSouthEast
            // 
            buttonSouthEast.Enabled = false;
            buttonSouthEast.Location = new Point(98, 114);
            buttonSouthEast.Name = "buttonSouthEast";
            buttonSouthEast.Size = new Size(85, 26);
            buttonSouthEast.TabIndex = 3;
            buttonSouthEast.Text = "SouthEast";
            buttonSouthEast.UseVisualStyleBackColor = true;
            buttonSouthEast.Click += buttonSouthEast_Click;
            // 
            // buttonEast
            // 
            buttonEast.Enabled = false;
            buttonEast.Location = new Point(98, 70);
            buttonEast.Name = "buttonEast";
            buttonEast.Size = new Size(85, 41);
            buttonEast.TabIndex = 5;
            buttonEast.Text = "East";
            buttonEast.UseVisualStyleBackColor = true;
            buttonEast.Click += buttonEast_Click;
            // 
            // buttonWest
            // 
            buttonWest.Enabled = false;
            buttonWest.Location = new Point(12, 70);
            buttonWest.Name = "buttonWest";
            buttonWest.Size = new Size(80, 41);
            buttonWest.TabIndex = 6;
            buttonWest.Text = "West";
            buttonWest.UseVisualStyleBackColor = true;
            buttonWest.Click += buttonWest_Click;
            // 
            // labelHints
            // 
            labelHints.AutoSize = true;
            labelHints.Location = new Point(388, 386);
            labelHints.Name = "labelHints";
            labelHints.Size = new Size(30, 15);
            labelHints.TabIndex = 13;
            labelHints.Text = "Hint";
            labelHints.Click += labelHints_Click;
            // 
            // labelArrows
            // 
            labelArrows.AutoSize = true;
            labelArrows.Location = new Point(113, 386);
            labelArrows.Name = "labelArrows";
            labelArrows.Size = new Size(47, 15);
            labelArrows.TabIndex = 14;
            labelArrows.Text = "Arrows:";
            // 
            // labelGold
            // 
            labelGold.AutoSize = true;
            labelGold.Location = new Point(166, 386);
            labelGold.Name = "labelGold";
            labelGold.Size = new Size(35, 15);
            labelGold.TabIndex = 15;
            labelGold.Text = "Gold:";
            // 
            // labelGoldAmount
            // 
            labelGoldAmount.AutoSize = true;
            labelGoldAmount.Location = new Point(179, 417);
            labelGoldAmount.Name = "labelGoldAmount";
            labelGoldAmount.Size = new Size(13, 15);
            labelGoldAmount.TabIndex = 18;
            labelGoldAmount.Text = "0";
            // 
            // labelArrowAmount
            // 
            labelArrowAmount.AutoSize = true;
            labelArrowAmount.Location = new Point(130, 417);
            labelArrowAmount.Name = "labelArrowAmount";
            labelArrowAmount.Size = new Size(13, 15);
            labelArrowAmount.TabIndex = 17;
            labelArrowAmount.Text = "0";
            // 
            // buttonShop
            // 
            buttonShop.Location = new Point(12, 378);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(95, 63);
            buttonShop.TabIndex = 20;
            buttonShop.Text = "Shop";
            buttonShop.UseVisualStyleBackColor = true;
            buttonShop.Click += buttonShop_Click;
            // 
            // labelScoreAmount
            // 
            labelScoreAmount.AutoSize = true;
            labelScoreAmount.Location = new Point(766, 417);
            labelScoreAmount.Name = "labelScoreAmount";
            labelScoreAmount.Size = new Size(13, 15);
            labelScoreAmount.TabIndex = 22;
            labelScoreAmount.Text = "0";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(749, 386);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(39, 15);
            labelScore.TabIndex = 21;
            labelScore.Text = "Score:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-12, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(818, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // labelHint3
            // 
            labelHint3.AutoSize = true;
            labelHint3.Location = new Point(388, 417);
            labelHint3.Name = "labelHint3";
            labelHint3.Size = new Size(30, 15);
            labelHint3.TabIndex = 24;
            labelHint3.Text = "Hint";
            // 
            // labelHint2
            // 
            labelHint2.AutoSize = true;
            labelHint2.Location = new Point(388, 402);
            labelHint2.Name = "labelHint2";
            labelHint2.Size = new Size(30, 15);
            labelHint2.TabIndex = 25;
            labelHint2.Text = "Hint";
            // 
            // labelAlerts
            // 
            labelAlerts.AutoSize = true;
            labelAlerts.Location = new Point(362, 12);
            labelAlerts.Name = "labelAlerts";
            labelAlerts.Size = new Size(38, 15);
            labelAlerts.TabIndex = 30;
            labelAlerts.Text = "label5";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAlerts);
            Controls.Add(labelHint2);
            Controls.Add(labelHint3);
            Controls.Add(labelScoreAmount);
            Controls.Add(labelScore);
            Controls.Add(buttonShop);
            Controls.Add(labelGoldAmount);
            Controls.Add(labelArrowAmount);
            Controls.Add(labelGold);
            Controls.Add(labelArrows);
            Controls.Add(labelHints);
            Controls.Add(buttonWest);
            Controls.Add(buttonEast);
            Controls.Add(buttonSouthEast);
            Controls.Add(buttonNorthWest);
            Controls.Add(buttonSouthWest);
            Controls.Add(buttonNorthEast);
            Controls.Add(pictureBox1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNorthEast;
        private Button buttonSouthWest;
        private Button buttonNorthWest;
        private Button buttonSouthEast;
        private Button buttonEast;
        private Button buttonWest;
        private Label labelHints;
        private Label labelArrows;
        private Label labelGold;
        private Label labelGoldAmount;
        private Label labelArrowAmount;
        private Button buttonShop;
        private Label labelScoreAmount;
        private Label labelScore;
        private PictureBox pictureBox1;
        private Label labelHint3;
        private Label labelHint2;
        private Label labelAlerts;
    }
}