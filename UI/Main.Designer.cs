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
            buttonSouthEast.Location = new Point(577, 376);
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
            buttonEast.Location = new Point(577, 245);
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
            label1.Location = new Point(294, 279);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Cave number";
            // 
            // textBoxCaveNumber
            // 
            textBoxCaveNumber.Location = new Point(401, 276);
            textBoxCaveNumber.Name = "textBoxCaveNumber";
            textBoxCaveNumber.Size = new Size(100, 23);
            textBoxCaveNumber.TabIndex = 8;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new Point(401, 333);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new Size(100, 23);
            textBoxRoomNumber.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 336);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 9;
            label2.Text = "Room number";
            // 
            // buttonCalculateRoomDirections
            // 
            buttonCalculateRoomDirections.Location = new Point(294, 404);
            buttonCalculateRoomDirections.Name = "buttonCalculateRoomDirections";
            buttonCalculateRoomDirections.Size = new Size(158, 23);
            buttonCalculateRoomDirections.TabIndex = 11;
            buttonCalculateRoomDirections.Text = "Calculate room directions";
            buttonCalculateRoomDirections.UseVisualStyleBackColor = true;
            buttonCalculateRoomDirections.Click += buttonCalculateRoomDirections_Click;
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.BackgroundImage = (Image)resources.GetObject("pictureBoxCoin.BackgroundImage");
            pictureBoxCoin.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxCoin.Location = new Point(452, 36);
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
            labelHints.Location = new Point(359, 36);
            labelHints.Name = "labelHints";
            labelHints.Size = new Size(30, 15);
            labelHints.TabIndex = 13;
            labelHints.Text = "Hint";
            labelHints.Click += labelHints_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}