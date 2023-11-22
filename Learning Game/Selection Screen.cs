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
    public partial class frm_select : Form
    {
        public frm_select()
        {
            InitializeComponent();
        }

        private void btn_math_Click(object sender, EventArgs e)
        {
            Form Math = new frm_math();
            Math.Show();
            this.Hide();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            Form Color = new frm_color();
            Color.Show();
            this.Hide();
        }

        private void btn_puzzle_Click(object sender, EventArgs e)
        {
            Form Puzzle = new frm_puzzle();
            Puzzle.Show();
            this.Hide();
        }
    }
}
