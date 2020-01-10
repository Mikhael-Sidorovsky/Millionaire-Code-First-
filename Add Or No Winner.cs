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
    public partial class Add_Or_No_Winner : Form
    {
        public event EventHandler<EventArgs> SaveWinner;
        public Add_Or_No_Winner()
        {
            InitializeComponent();
            picture.Image = Image.FromFile(@"winner.jpg");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveWinner?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
