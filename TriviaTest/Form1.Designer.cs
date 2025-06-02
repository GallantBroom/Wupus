namespace TriviaTest
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
            textBoxQuestion = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            buttonSubmit = new Button();
            buttonGet_Question = new Button();
            SuspendLayout();
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Location = new Point(152, 125);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.ReadOnly = true;
            textBoxQuestion.Size = new Size(100, 25);
            textBoxQuestion.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(281, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(33, 21);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(281, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(33, 21);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(281, 102);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(33, 21);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(281, 129);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(33, 21);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(411, 129);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 5;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonGet_Question
            // 
            buttonGet_Question.Location = new Point(411, 91);
            buttonGet_Question.Name = "buttonGet_Question";
            buttonGet_Question.Size = new Size(108, 23);
            buttonGet_Question.TabIndex = 6;
            buttonGet_Question.Text = "Get Question";
            buttonGet_Question.UseVisualStyleBackColor = true;
            buttonGet_Question.Click += buttonGet_Question_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGet_Question);
            Controls.Add(buttonSubmit);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBoxQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxQuestion;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button buttonSubmit;
        private Button buttonGet_Question;
    }
}
