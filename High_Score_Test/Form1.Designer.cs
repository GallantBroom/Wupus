namespace High_Score_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxScore = new TextBox();
            labelCave = new Label();
            textBoxCave = new TextBox();
            labelScore = new Label();
            buttonAdd_High_Score = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(59, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(43, 17);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(151, 46);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 25);
            textBoxName.TabIndex = 1;
            // 
            // textBoxScore
            // 
            textBoxScore.Location = new Point(151, 146);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(100, 25);
            textBoxScore.TabIndex = 3;
            // 
            // labelCave
            // 
            labelCave.AutoSize = true;
            labelCave.Location = new Point(59, 101);
            labelCave.Name = "labelCave";
            labelCave.Size = new Size(36, 17);
            labelCave.TabIndex = 2;
            labelCave.Text = "Cave";
            // 
            // textBoxCave
            // 
            textBoxCave.Location = new Point(151, 93);
            textBoxCave.Name = "textBoxCave";
            textBoxCave.Size = new Size(100, 25);
            textBoxCave.TabIndex = 5;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(59, 149);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(41, 17);
            labelScore.TabIndex = 4;
            labelScore.Text = "Score";
            // 
            // buttonAdd_High_Score
            // 
            buttonAdd_High_Score.Location = new Point(151, 209);
            buttonAdd_High_Score.Name = "buttonAdd_High_Score";
            buttonAdd_High_Score.Size = new Size(100, 47);
            buttonAdd_High_Score.TabIndex = 6;
            buttonAdd_High_Score.Text = "Add High Score";
            buttonAdd_High_Score.UseVisualStyleBackColor = true;
            buttonAdd_High_Score.Click += buttonAdd_High_Score_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(323, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(426, 361);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(buttonAdd_High_Score);
            Controls.Add(textBoxCave);
            Controls.Add(labelScore);
            Controls.Add(textBoxScore);
            Controls.Add(labelCave);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "High Score Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxScore;
        private Label labelCave;
        private TextBox textBoxCave;
        private Label labelScore;
        private Button buttonAdd_High_Score;
        private ListBox listBox1;
    }
}
