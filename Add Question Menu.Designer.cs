namespace Millionaire
{
    partial class Admin_menu
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
            this.Question = new System.Windows.Forms.TextBox();
            this.QuestionTitle = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnswerB = new System.Windows.Forms.TextBox();
            this.AnswerC = new System.Windows.Forms.TextBox();
            this.AnswerD = new System.Windows.Forms.TextBox();
            this.RightAnswer = new System.Windows.Forms.GroupBox();
            this.Answer2 = new System.Windows.Forms.GroupBox();
            this.Answer3 = new System.Windows.Forms.GroupBox();
            this.Answer4 = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.QuestionTitle.SuspendLayout();
            this.RightAnswer.SuspendLayout();
            this.Answer2.SuspendLayout();
            this.Answer3.SuspendLayout();
            this.Answer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(14, 19);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(726, 20);
            this.Question.TabIndex = 0;
            this.Question.TextChanged += new System.EventHandler(this.Question_TextChanged);
            // 
            // QuestionTitle
            // 
            this.QuestionTitle.Controls.Add(this.Question);
            this.QuestionTitle.Location = new System.Drawing.Point(12, 12);
            this.QuestionTitle.Name = "QuestionTitle";
            this.QuestionTitle.Size = new System.Drawing.Size(760, 55);
            this.QuestionTitle.TabIndex = 1;
            this.QuestionTitle.TabStop = false;
            this.QuestionTitle.Text = "Question Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(726, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AnswerB
            // 
            this.AnswerB.Location = new System.Drawing.Point(14, 19);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(726, 20);
            this.AnswerB.TabIndex = 3;
            this.AnswerB.TextChanged += new System.EventHandler(this.AnswerB_TextChanged);
            // 
            // AnswerC
            // 
            this.AnswerC.Location = new System.Drawing.Point(14, 19);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(726, 20);
            this.AnswerC.TabIndex = 4;
            this.AnswerC.TextChanged += new System.EventHandler(this.AnswerC_TextChanged);
            // 
            // AnswerD
            // 
            this.AnswerD.Location = new System.Drawing.Point(14, 19);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(726, 20);
            this.AnswerD.TabIndex = 5;
            this.AnswerD.TextChanged += new System.EventHandler(this.AnswerD_TextChanged);
            // 
            // RightAnswer
            // 
            this.RightAnswer.Controls.Add(this.textBox1);
            this.RightAnswer.Location = new System.Drawing.Point(12, 91);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(760, 61);
            this.RightAnswer.TabIndex = 6;
            this.RightAnswer.TabStop = false;
            this.RightAnswer.Text = "Rigt answer";
            // 
            // Answer2
            // 
            this.Answer2.Controls.Add(this.AnswerB);
            this.Answer2.Location = new System.Drawing.Point(12, 176);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(760, 62);
            this.Answer2.TabIndex = 7;
            this.Answer2.TabStop = false;
            this.Answer2.Text = "Aswer 2";
            // 
            // Answer3
            // 
            this.Answer3.Controls.Add(this.AnswerC);
            this.Answer3.Location = new System.Drawing.Point(12, 268);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(760, 62);
            this.Answer3.TabIndex = 8;
            this.Answer3.TabStop = false;
            this.Answer3.Text = "Answer 3";
            // 
            // Answer4
            // 
            this.Answer4.Controls.Add(this.AnswerD);
            this.Answer4.Location = new System.Drawing.Point(12, 366);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(760, 69);
            this.Answer4.TabIndex = 9;
            this.Answer4.TabStop = false;
            this.Answer4.Text = "Answer 4";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Green;
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.Location = new System.Drawing.Point(609, 441);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(163, 33);
            this.ButtonAdd.TabIndex = 10;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(395, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 33);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level of question";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(260, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Level 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(180, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Level 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(102, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Level 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.QuestionTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_menu";
            this.Text = "Add question";
            this.QuestionTitle.ResumeLayout(false);
            this.QuestionTitle.PerformLayout();
            this.RightAnswer.ResumeLayout(false);
            this.RightAnswer.PerformLayout();
            this.Answer2.ResumeLayout(false);
            this.Answer2.PerformLayout();
            this.Answer3.ResumeLayout(false);
            this.Answer3.PerformLayout();
            this.Answer4.ResumeLayout(false);
            this.Answer4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.GroupBox QuestionTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox AnswerB;
        private System.Windows.Forms.TextBox AnswerC;
        private System.Windows.Forms.TextBox AnswerD;
        private System.Windows.Forms.GroupBox RightAnswer;
        private System.Windows.Forms.GroupBox Answer2;
        private System.Windows.Forms.GroupBox Answer3;
        private System.Windows.Forms.GroupBox Answer4;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}