namespace UI
{
    partial class Game_Over
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
            buttonViewHighScores = new Button();
            labelGameOver = new Label();
            SuspendLayout();
            // 
            // buttonViewHighScores
            // 
            buttonViewHighScores.Location = new Point(237, 305);
            buttonViewHighScores.Name = "buttonViewHighScores";
            buttonViewHighScores.Size = new Size(265, 76);
            buttonViewHighScores.TabIndex = 0;
            buttonViewHighScores.Text = "View High Scores";
            buttonViewHighScores.UseVisualStyleBackColor = true;
            buttonViewHighScores.Visible = false;
            // 
            // labelGameOver
            // 
            labelGameOver.AutoSize = true;
            labelGameOver.Font = new Font("Segoe UI Emoji", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGameOver.Location = new Point(173, 9);
            labelGameOver.Name = "labelGameOver";
            labelGameOver.Size = new Size(372, 85);
            labelGameOver.TabIndex = 1;
            labelGameOver.Text = "Game Over!";
            // 
            // Game_Over
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelGameOver);
            Controls.Add(buttonViewHighScores);
            Name = "Game_Over";
            Text = "Game_Over";
            Load += Game_Over_Load;
            Click += Game_Over_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonViewHighScores;
        private Label labelGameOver;
    }
}