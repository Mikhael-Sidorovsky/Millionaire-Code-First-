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
    public partial class Add_Winner : Form
    {
        public bool IsSave;
        public string WinnerName { get; set; }
        public string WinnerLastName { get; set; }
        public event EventHandler<EventArgs> SaveClick;

        public Add_Winner()
        {
            InitializeComponent();
            IsSave = false;
            WinnerName = "";
            WinnerLastName = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            WinnerName = textBox1.Text;
            IsSaveEnabled();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            WinnerLastName = textBox2.Text;
            IsSaveEnabled();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveClick?.Invoke(this, EventArgs.Empty);
            if (IsSave)
                MessageBox.Show("Saving successfully!");
            else
                MessageBox.Show("Saving failed!");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IsSaveEnabled()
        {
            if (WinnerName != "" && WinnerLastName != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
