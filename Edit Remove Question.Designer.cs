namespace Millionaire
{
    partial class Edit_Remove_Question
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
            this.ListOfQuestions = new System.Windows.Forms.ComboBox();
            this.SelectQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Level3 = new System.Windows.Forms.RadioButton();
            this.Level2 = new System.Windows.Forms.RadioButton();
            this.Level1 = new System.Windows.Forms.RadioButton();
            this.Question = new System.Windows.Forms.TextBox();
            this.RightAnswer = new System.Windows.Forms.TextBox();
            this.Answer2 = new System.Windows.Forms.TextBox();
            this.Answer3 = new System.Windows.Forms.TextBox();
            this.Answer4 = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfQuestions
            // 
            this.ListOfQuestions.BackColor = System.Drawing.SystemColors.Window;
            this.ListOfQuestions.FormattingEnabled = true;
            this.ListOfQuestions.Location = new System.Drawing.Point(12, 35);
            this.ListOfQuestions.Name = "ListOfQuestions";
            this.ListOfQuestions.Size = new System.Drawing.Size(776, 21);
            this.ListOfQuestions.TabIndex = 0;
            this.ListOfQuestions.SelectedIndexChanged += new System.EventHandler(this.ListOfQuestions_SelectedIndexChanged);
            // 
            // SelectQuestion
            // 
            this.SelectQuestion.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectQuestion.ForeColor = System.Drawing.Color.OliveDrab;
            this.SelectQuestion.Location = new System.Drawing.Point(661, 9);
            this.SelectQuestion.Name = "SelectQuestion";
            this.SelectQuestion.Size = new System.Drawing.Size(127, 23);
            this.SelectQuestion.TabIndex = 1;
            this.SelectQuestion.Text = "Select question:";
            this.SelectQuestion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right answer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Answer 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Answer 3:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(9, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Answer 4:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Level3);
            this.groupBox1.Controls.Add(this.Level2);
            this.groupBox1.Controls.Add(this.Level1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level";
            // 
            // Level3
            // 
            this.Level3.AutoSize = true;
            this.Level3.Location = new System.Drawing.Point(188, 19);
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(78, 22);
            this.Level3.TabIndex = 2;
            this.Level3.TabStop = true;
            this.Level3.Text = "Level 3";
            this.Level3.UseVisualStyleBackColor = true;
            this.Level3.CheckedChanged += new System.EventHandler(this.Level3_CheckedChanged);
            // 
            // Level2
            // 
            this.Level2.AutoSize = true;
            this.Level2.Location = new System.Drawing.Point(97, 19);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(78, 22);
            this.Level2.TabIndex = 1;
            this.Level2.TabStop = true;
            this.Level2.Text = "Level 2";
            this.Level2.UseVisualStyleBackColor = true;
            this.Level2.CheckedChanged += new System.EventHandler(this.Level2_CheckedChanged);
            // 
            // Level1
            // 
            this.Level1.AutoSize = true;
            this.Level1.Location = new System.Drawing.Point(6, 19);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(78, 22);
            this.Level1.TabIndex = 0;
            this.Level1.TabStop = true;
            this.Level1.Text = "Level 1";
            this.Level1.UseVisualStyleBackColor = true;
            this.Level1.CheckedChanged += new System.EventHandler(this.Level1_CheckedChanged);
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(12, 85);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(776, 20);
            this.Question.TabIndex = 8;
            this.Question.TextChanged += new System.EventHandler(this.Question_TextChanged);
            // 
            // RightAnswer
            // 
            this.RightAnswer.Location = new System.Drawing.Point(12, 134);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(776, 20);
            this.RightAnswer.TabIndex = 9;
            this.RightAnswer.TextChanged += new System.EventHandler(this.RightAnswer_TextChanged);
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(12, 183);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(776, 20);
            this.Answer2.TabIndex = 10;
            this.Answer2.TextChanged += new System.EventHandler(this.Answer2_TextChanged);
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(12, 238);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(776, 20);
            this.Answer3.TabIndex = 11;
            this.Answer3.TextChanged += new System.EventHandler(this.Answer3_TextChanged);
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(12, 287);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(776, 20);
            this.Answer4.TabIndex = 12;
            this.Answer4.TextChanged += new System.EventHandler(this.Answer4_TextChanged);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Gold;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remove.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Remove.Location = new System.Drawing.Point(550, 313);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(116, 47);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Remove question";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.YellowGreen;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Change.Location = new System.Drawing.Point(672, 313);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(116, 48);
            this.Change.TabIndex = 14;
            this.Change.Text = "Change question";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Exit.Location = new System.Drawing.Point(428, 313);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 48);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edit_Remove_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectQuestion);
            this.Controls.Add(this.ListOfQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Remove_Question";
            this.Text = "Edit or Remove or show question";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListOfQuestions;
        private System.Windows.Forms.Label SelectQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Level3;
        private System.Windows.Forms.RadioButton Level2;
        private System.Windows.Forms.RadioButton Level1;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.TextBox RightAnswer;
        private System.Windows.Forms.TextBox Answer2;
        private System.Windows.Forms.TextBox Answer3;
        private System.Windows.Forms.TextBox Answer4;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Exit;
    }
}