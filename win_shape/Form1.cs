using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grp_Square.Visible = false;
            grp_Rectangle.Visible = false;
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDIsplay_Click(object sender, EventArgs e)
        {
            if (rd_Rectangle.Checked)
            {
                Rectangle rec = new Rectangle(txtName.Text, int.Parse(txtSides.Text), double.Parse(txtrecLength.Text), double.Parse(txtWidth.Text));
                MessageBox.Show(rec.ToString());
            }
            else
            {
                Square sq = new Square(txtName.Text, int.Parse(txtSides.Text), double.Parse(txtsqLength.Text));
                MessageBox.Show(sq.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void rd_Square_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Square.Checked)
            {
                grp_Square.Visible = true;
            }
            else
            {
                grp_Square.Visible = false;
            }
        }

        private void rd_Rectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Rectangle.Checked)
            {
                grp_Rectangle.Visible = true;
            }
            else
            {
                grp_Rectangle.Visible = false;
            }
        }
    }
}
