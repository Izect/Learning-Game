using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Game
{
    public partial class LearningGameForm1 : Form
    {
        public LearningGameForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Select = new frm_select();
            Select.Show();
            this.Hide();
        }
    }
}
