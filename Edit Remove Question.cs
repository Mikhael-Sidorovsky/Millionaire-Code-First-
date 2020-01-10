using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Edit_Remove_Question : Form
    {
        public List<Question> questions;
        public Question ProcessingQuestion;
        public event EventHandler<EventArgs> Click_Change;
        public event EventHandler<EventArgs> Click_Remove;
        public Edit_Remove_Question()
        {
            InitializeComponent();
        }

        private void ListOfQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessingQuestion = (Question)ListOfQuestions.SelectedItem;
            PrintQuestionInfo(ProcessingQuestion);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Click_Remove?.Invoke(this, EventArgs.Empty);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Click_Change?.Invoke(this, EventArgs.Empty);
        }

        public void LoadListOfQuestion(List<Question> list)
        {
            questions = list;
            ListOfQuestions.DataSource = questions;
            ListOfQuestions.DisplayMember = "Title";
            ListOfQuestions.ValueMember = "Id";
        }

        private void PrintQuestionInfo(Question question)
        {
            Question.Text = question.Title;
            RightAnswer.Text = question.rightAnswer;
            Answer2.Text = question.Answer1;
            Answer3.Text = question.Answer2;
            Answer4.Text = question.Answer3;
            switch(question.Level)
            {
                case 1:
                    Level1.Checked = true;
                    break;
                case 2:
                    Level2.Checked = true;
                    break;
                case 3:
                    Level3.Checked = true;
                    break;
            }
        }

        private void Question_TextChanged(object sender, EventArgs e)
        {
            ProcessingQuestion.Title = Question.Text;
        }

        private void RightAnswer_TextChanged(object sender, EventArgs e)
        {
            ProcessingQuestion.rightAnswer = RightAnswer.Text;
        }

        private void Answer2_TextChanged(object sender, EventArgs e)
        {
            ProcessingQuestion.Answer1 = Answer2.Text;
        }

        private void Answer3_TextChanged(object sender, EventArgs e)
        {
            ProcessingQuestion.Answer2 = Answer3.Text;
        }

        private void Answer4_TextChanged(object sender, EventArgs e)
        {
            ProcessingQuestion.Answer3 = Answer4.Text;
        }

        private void Level1_CheckedChanged(object sender, EventArgs e)
        {
            if (Level1.Checked)
                ProcessingQuestion.Level = 1;
        }

        private void Level2_CheckedChanged(object sender, EventArgs e)
        {
            if (Level2.Checked)
                ProcessingQuestion.Level = 2;
        }

        private void Level3_CheckedChanged(object sender, EventArgs e)
        {
            if (Level3.Checked)
                ProcessingQuestion.Level = 3;
        }
    }
}
