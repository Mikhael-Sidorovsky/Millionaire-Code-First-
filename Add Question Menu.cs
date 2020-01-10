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
    public partial class Admin_menu : Form
    {
        // для полей класса Question
        public string Title { get; set; }
        public string RightAnsw { get; set; }
        public string AnswB { get; set; }
        public string AnswC { get; set; }
        public string AnswD { get; set; }
        public int Level { get; set; }

        public event EventHandler<EventArgs> Add;

        public Admin_menu()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Title = Question.Text;
            RightAnsw = textBox1.Text;
            AnswB = AnswerB.Text;
            AnswC = AnswerC.Text;
            AnswD = AnswerD.Text;
            Question.Text = "";
            textBox1.Text = "";
            AnswerB.Text = "";
            AnswerC.Text = "";
            AnswerD.Text = "";
            switch(Level)
            {
                case 1:
                    radioButton1.Checked = false;
                    break;
                case 2:
                    radioButton2.Checked = false;
                    break;
                case 3:
                    radioButton3.Checked = false;
                    break;
            }
            ButtonAdd.Enabled = false;
            Add?.Invoke(this, EventArgs.Empty);
        }

        private void CheckState()
        {
            if (Question.Text != "" && RightAnswer.Text != "" && AnswerB.Text != "" && AnswerC.Text != "" && 
                AnswerD.Text != "" && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
                ButtonAdd.Enabled = true;
            else
                ButtonAdd.Enabled = false;
        }

        private void Question_TextChanged(object sender, EventArgs e)
        {
            CheckState();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckState();
        }

        private void AnswerB_TextChanged(object sender, EventArgs e)
        {
            CheckState();
        }

        private void AnswerC_TextChanged(object sender, EventArgs e)
        {
            CheckState();
        }

        private void AnswerD_TextChanged(object sender, EventArgs e)
        {
            CheckState();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Level = 1;
            CheckState();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Level = 2;
            CheckState();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Level = 3;
            CheckState();
        }        
    }
}
