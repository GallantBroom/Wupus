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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonWest);
            Controls.Add(buttonEast);
            Controls.Add(buttonSouthEast);
            Controls.Add(buttonNorthWest);
            Controls.Add(buttonSouthWest);
            Controls.Add(buttonNorthEast);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNorthEast;
        private Button buttonSouthWest;
        private Button buttonNorthWest;
        private Button buttonSouthEast;
        private Button buttonEast;
        private Button buttonWest;
    }
}