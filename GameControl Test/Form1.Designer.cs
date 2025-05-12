namespace GameControl_Test
{
    partial class FormgameControlTest
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
            buttonReturnCave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonReturnCave
            // 
            buttonReturnCave.Location = new Point(462, 158);
            buttonReturnCave.Name = "buttonReturnCave";
            buttonReturnCave.Size = new Size(150, 47);
            buttonReturnCave.TabIndex = 0;
            buttonReturnCave.Text = "Return Cave";
            buttonReturnCave.UseVisualStyleBackColor = true;
            buttonReturnCave.Click += buttonReturnCave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 225);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // FormgameControlTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonReturnCave);
            Name = "FormgameControlTest";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturnCave;
        private Label label1;
    }
}
