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
            label1 = new Label();
            textBoxCave = new TextBox();
            labelCave = new Label();
            label2 = new Label();
            textBoxRoomNumber = new TextBox();
            textBoxConnectingRooms = new TextBox();
            textBoxbool = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonCave1
            // 
            buttonCave1.Location = new Point(381, 187);
            buttonCave1.Name = "buttonCave1";
            buttonCave1.Size = new Size(218, 23);
            buttonCave1.TabIndex = 0;
            buttonCave1.Text = "Calculate Connecting Rooms";
            buttonCave1.UseVisualStyleBackColor = true;
            buttonCave1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 74);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 5;
            label1.Text = "Connecting Rooms";
            // 
            // textBoxCave
            // 
            textBoxCave.Location = new Point(307, 71);
            textBoxCave.Name = "textBoxCave";
            textBoxCave.Size = new Size(100, 23);
            textBoxCave.TabIndex = 6;
            // 
            // labelCave
            // 
            labelCave.AutoSize = true;
            labelCave.Location = new Point(207, 74);
            labelCave.Name = "labelCave";
            labelCave.Size = new Size(80, 15);
            labelCave.TabIndex = 7;
            labelCave.Text = "Cave Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 119);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 9;
            label2.Text = "Room Number";
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new Point(306, 116);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new Size(100, 23);
            textBoxRoomNumber.TabIndex = 8;
            // 
            // textBoxConnectingRooms
            // 
            textBoxConnectingRooms.Location = new Point(610, 71);
            textBoxConnectingRooms.Name = "textBoxConnectingRooms";
            textBoxConnectingRooms.ReadOnly = true;
            textBoxConnectingRooms.Size = new Size(57, 23);
            textBoxConnectingRooms.TabIndex = 10;
            textBoxConnectingRooms.Text = "0, 0, 0";
            // 
            // textBoxbool
            // 
            textBoxbool.Location = new Point(349, 307);
            textBoxbool.Name = "textBoxbool";
            textBoxbool.ReadOnly = true;
            textBoxbool.Size = new Size(294, 23);
            textBoxbool.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 310);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 11;
            label3.Text = "Directions";
            // 
            // FormCave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxbool);
            Controls.Add(label3);
            Controls.Add(textBoxConnectingRooms);
            Controls.Add(label2);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(labelCave);
            Controls.Add(textBoxCave);
            Controls.Add(label1);
            Controls.Add(buttonCave1);
            Name = "FormCave";
            Text = "Cave";
            Load += FormCave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCave1;
        private Label label1;
        private TextBox textBoxCave;
        private Label labelCave;
        private Label label2;
        private TextBox textBoxRoomNumber;
        private TextBox textBoxConnectingRooms;
        private TextBox textBoxbool;
        private Label label3;
    }
}
