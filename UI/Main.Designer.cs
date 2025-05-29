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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            buttonNorthEast = new Button();
            buttonSouthWest = new Button();
            buttonNorthWest = new Button();
            buttonSouthEast = new Button();
            buttonEast = new Button();
            buttonWest = new Button();
            label1 = new Label();
            textBoxCaveNumber = new TextBox();
            textBoxRoomNumber = new TextBox();
            label2 = new Label();
            buttonCalculateRoomDirections = new Button();
            pictureBoxCoin = new PictureBox();
            labelHints = new Label();
            labelArrows = new Label();
            labelGold = new Label();
            label5 = new Label();
            label6 = new Label();
            labelGoldAmount = new Label();
            labelArrowAmount = new Label();
            buttonShop = new Button();
            labelScoreAmount = new Label();
            labelScore = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            SuspendLayout();
            // 
            // buttonNorthEast
            // 
            buttonNorthEast.Enabled = false;
            buttonNorthEast.Location = new Point(657, 12);
            buttonNorthEast.Name = "buttonNorthEast";
            buttonNorthEast.Size = new Size(85, 125);
            buttonNorthEast.TabIndex = 0;
            buttonNorthEast.Text = "NorthEast";
            buttonNorthEast.UseVisualStyleBackColor = true;
            buttonNorthEast.Click += buttonNorthEast_Click;
            // 
            // buttonSouthWest
            // 
            buttonSouthWest.Enabled = false;
            buttonSouthWest.Location = new Point(29, 382);
            buttonSouthWest.Name = "buttonSouthWest";
            buttonSouthWest.Size = new Size(111, 23);
            buttonSouthWest.TabIndex = 1;
            buttonSouthWest.Text = "SouthWest";
            buttonSouthWest.UseVisualStyleBackColor = true;
            buttonSouthWest.Click += buttonSouthWest_Click;
            // 
            // buttonNorthWest
            // 
            buttonNorthWest.Enabled = false;
            buttonNorthWest.Location = new Point(41, 18);
            buttonNorthWest.Name = "buttonNorthWest";
            buttonNorthWest.Size = new Size(86, 112);
            buttonNorthWest.TabIndex = 2;
            buttonNorthWest.Text = "NorthWest";
            buttonNorthWest.UseVisualStyleBackColor = true;
            buttonNorthWest.Click += buttonNorthWest_Click;
            // 
            // buttonSouthEast
            // 
            buttonSouthEast.Enabled = false;
            buttonSouthEast.Location = new Point(622, 369);
            buttonSouthEast.Name = "buttonSouthEast";
            buttonSouthEast.Size = new Size(120, 29);
            buttonSouthEast.TabIndex = 3;
            buttonSouthEast.Text = "SouthEast";
            buttonSouthEast.UseVisualStyleBackColor = true;
            buttonSouthEast.Click += buttonSouthEast_Click;
            // 
            // buttonEast
            // 
            buttonEast.Enabled = false;
            buttonEast.Location = new Point(657, 245);
            buttonEast.Name = "buttonEast";
            buttonEast.Size = new Size(153, 41);
            buttonEast.TabIndex = 5;
            buttonEast.Text = "East";
            buttonEast.UseVisualStyleBackColor = true;
            buttonEast.Click += buttonEast_Click;
            // 
            // buttonWest
            // 
            buttonWest.Enabled = false;
            buttonWest.Location = new Point(19, 245);
            buttonWest.Name = "buttonWest";
            buttonWest.Size = new Size(153, 41);
            buttonWest.TabIndex = 6;
            buttonWest.Text = "West";
            buttonWest.UseVisualStyleBackColor = true;
            buttonWest.Click += buttonWest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 203);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Cave number";
            // 
            // textBoxCaveNumber
            // 
            textBoxCaveNumber.Location = new Point(348, 195);
            textBoxCaveNumber.Name = "textBoxCaveNumber";
            textBoxCaveNumber.Size = new Size(92, 23);
            textBoxCaveNumber.TabIndex = 8;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new Point(348, 291);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new Size(92, 23);
            textBoxRoomNumber.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 291);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 9;
            label2.Text = "Room number";
            // 
            // buttonCalculateRoomDirections
            // 
            buttonCalculateRoomDirections.Location = new Point(364, 245);
            buttonCalculateRoomDirections.Name = "buttonCalculateRoomDirections";
            buttonCalculateRoomDirections.Size = new Size(108, 23);
            buttonCalculateRoomDirections.TabIndex = 11;
            buttonCalculateRoomDirections.Text = "Calculate room directions";
            buttonCalculateRoomDirections.UseVisualStyleBackColor = true;
            buttonCalculateRoomDirections.Click += buttonCalculateRoomDirections_Click;
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.BackgroundImage = (Image)resources.GetObject("pictureBoxCoin.BackgroundImage");
            pictureBoxCoin.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxCoin.Location = new Point(733, 173);
            pictureBoxCoin.Name = "pictureBoxCoin";
            pictureBoxCoin.Size = new Size(37, 16);
            pictureBoxCoin.TabIndex = 12;
            pictureBoxCoin.TabStop = false;
            pictureBoxCoin.Visible = false;
            pictureBoxCoin.Click += pictureBoxCoin_Click;
            // 
            // labelHints
            // 
            labelHints.AutoSize = true;
            labelHints.Location = new Point(198, 18);
            labelHints.Name = "labelHints";
            labelHints.Size = new Size(30, 15);
            labelHints.TabIndex = 13;
            labelHints.Text = "Hint";
            labelHints.Click += labelHints_Click;
            // 
            // labelArrows
            // 
            labelArrows.AutoSize = true;
            labelArrows.Location = new Point(249, 386);
            labelArrows.Name = "labelArrows";
            labelArrows.Size = new Size(47, 15);
            labelArrows.TabIndex = 14;
            labelArrows.Text = "Arrows:";
            // 
            // labelGold
            // 
            labelGold.AutoSize = true;
            labelGold.Location = new Point(405, 386);
            labelGold.Name = "labelGold";
            labelGold.Size = new Size(35, 15);
            labelGold.TabIndex = 15;
            labelGold.Text = "Gold:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 386);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 426);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 19;
            label6.Text = "label6";
            // 
            // labelGoldAmount
            // 
            labelGoldAmount.AutoSize = true;
            labelGoldAmount.Location = new Point(418, 417);
            labelGoldAmount.Name = "labelGoldAmount";
            labelGoldAmount.Size = new Size(13, 15);
            labelGoldAmount.TabIndex = 18;
            labelGoldAmount.Text = "0";
            // 
            // labelArrowAmount
            // 
            labelArrowAmount.AutoSize = true;
            labelArrowAmount.Location = new Point(266, 417);
            labelArrowAmount.Name = "labelArrowAmount";
            labelArrowAmount.Size = new Size(13, 15);
            labelArrowAmount.TabIndex = 17;
            labelArrowAmount.Text = "0";
            // 
            // buttonShop
            // 
            buttonShop.Location = new Point(468, 378);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(95, 63);
            buttonShop.TabIndex = 20;
            buttonShop.Text = "Shop";
            buttonShop.UseVisualStyleBackColor = true;
            // 
            // labelScoreAmount
            // 
            labelScoreAmount.AutoSize = true;
            labelScoreAmount.Location = new Point(583, 40);
            labelScoreAmount.Name = "labelScoreAmount";
            labelScoreAmount.Size = new Size(13, 15);
            labelScoreAmount.TabIndex = 22;
            labelScoreAmount.Text = "0";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(566, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(39, 15);
            labelScore.TabIndex = 21;
            labelScore.Text = "Score:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelScoreAmount);
            Controls.Add(labelScore);
            Controls.Add(buttonShop);
            Controls.Add(label6);
            Controls.Add(labelGoldAmount);
            Controls.Add(labelArrowAmount);
            Controls.Add(label5);
            Controls.Add(labelGold);
            Controls.Add(labelArrows);
            Controls.Add(labelHints);
            Controls.Add(pictureBoxCoin);
            Controls.Add(buttonCalculateRoomDirections);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(label2);
            Controls.Add(textBoxCaveNumber);
            Controls.Add(label1);
            Controls.Add(buttonWest);
            Controls.Add(buttonEast);
            Controls.Add(buttonSouthEast);
            Controls.Add(buttonNorthWest);
            Controls.Add(buttonSouthWest);
            Controls.Add(buttonNorthEast);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
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
        private Label label1;
        private TextBox textBoxCaveNumber;
        private TextBox textBoxRoomNumber;
        private Label label2;
        private Button buttonCalculateRoomDirections;
        private PictureBox pictureBoxCoin;
        private Label labelHints;
        private Label labelArrows;
        private Label labelGold;
        private Label label5;
        private Label label6;
        private Label labelGoldAmount;
        private Label labelArrowAmount;
        private Button buttonShop;
        private Label labelScoreAmount;
        private Label labelScore;
    }
}