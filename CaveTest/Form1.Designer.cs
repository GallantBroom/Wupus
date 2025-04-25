namespace CaveTest
{
    partial class FormCave
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
            buttonCave1 = new Button();
            buttonCave2 = new Button();
            buttonCave3 = new Button();
            buttonCave4 = new Button();
            buttonCave5 = new Button();
            SuspendLayout();
            // 
            // buttonCave1
            // 
            buttonCave1.Location = new Point(72, 213);
            buttonCave1.Name = "buttonCave1";
            buttonCave1.Size = new Size(75, 23);
            buttonCave1.TabIndex = 0;
            buttonCave1.Text = "Cave 1";
            buttonCave1.UseVisualStyleBackColor = true;
            buttonCave1.Click += button1_Click;
            // 
            // buttonCave2
            // 
            buttonCave2.Location = new Point(192, 213);
            buttonCave2.Name = "buttonCave2";
            buttonCave2.Size = new Size(75, 23);
            buttonCave2.TabIndex = 1;
            buttonCave2.Text = "Cave 2";
            buttonCave2.UseVisualStyleBackColor = true;
            // 
            // buttonCave3
            // 
            buttonCave3.Location = new Point(332, 213);
            buttonCave3.Name = "buttonCave3";
            buttonCave3.Size = new Size(75, 23);
            buttonCave3.TabIndex = 2;
            buttonCave3.Text = "Cave 3";
            buttonCave3.UseVisualStyleBackColor = true;
            // 
            // buttonCave4
            // 
            buttonCave4.Location = new Point(451, 213);
            buttonCave4.Name = "buttonCave4";
            buttonCave4.Size = new Size(75, 23);
            buttonCave4.TabIndex = 3;
            buttonCave4.Text = "Cave 4";
            buttonCave4.UseVisualStyleBackColor = true;
            // 
            // buttonCave5
            // 
            buttonCave5.Location = new Point(602, 213);
            buttonCave5.Name = "buttonCave5";
            buttonCave5.Size = new Size(75, 23);
            buttonCave5.TabIndex = 4;
            buttonCave5.Text = "Cave 5";
            buttonCave5.UseVisualStyleBackColor = true;
            // 
            // FormCave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCave5);
            Controls.Add(buttonCave4);
            Controls.Add(buttonCave3);
            Controls.Add(buttonCave2);
            Controls.Add(buttonCave1);
            Name = "FormCave";
            Text = "Cave";
            Load += FormCave_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCave1;
        private Button buttonCave2;
        private Button buttonCave3;
        private Button buttonCave4;
        private Button buttonCave5;
    }
}
