namespace GameLocationTest1
{
    partial class Form1
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
            this.textBoxTraps = new System.Windows.Forms.TextBox();
            this.textBoxPits = new System.Windows.Forms.TextBox();
            this.textBoxWumpus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSpawn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTraps
            // 
            this.textBoxTraps.Location = new System.Drawing.Point(149, 56);
            this.textBoxTraps.Name = "textBoxTraps";
            this.textBoxTraps.Size = new System.Drawing.Size(100, 20);
            this.textBoxTraps.TabIndex = 0;
            // 
            // textBoxPits
            // 
            this.textBoxPits.Location = new System.Drawing.Point(400, 55);
            this.textBoxPits.Name = "textBoxPits";
            this.textBoxPits.Size = new System.Drawing.Size(100, 20);
            this.textBoxPits.TabIndex = 1;
            // 
            // textBoxWumpus
            // 
            this.textBoxWumpus.Location = new System.Drawing.Point(670, 55);
            this.textBoxWumpus.Name = "textBoxWumpus";
            this.textBoxWumpus.Size = new System.Drawing.Size(100, 20);
            this.textBoxWumpus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Traps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wumpus";
            // 
            // buttonSpawn
            // 
            this.buttonSpawn.Location = new System.Drawing.Point(85, 160);
            this.buttonSpawn.Name = "buttonSpawn";
            this.buttonSpawn.Size = new System.Drawing.Size(118, 40);
            this.buttonSpawn.TabIndex = 6;
            this.buttonSpawn.Text = "Spawn";
            this.buttonSpawn.UseVisualStyleBackColor = true;
            this.buttonSpawn.Click += new System.EventHandler(this.buttonSpawn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSpawn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWumpus);
            this.Controls.Add(this.textBoxPits);
            this.Controls.Add(this.textBoxTraps);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTraps;
        private System.Windows.Forms.TextBox textBoxPits;
        private System.Windows.Forms.TextBox textBoxWumpus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSpawn;
    }
}

