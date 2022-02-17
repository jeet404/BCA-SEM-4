using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBtnDemo
{
    public partial class Form1 : Form
    {
        string lbl_data = "You have selected";
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtn_red_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_red.BackColor = Color.Red;
            rbtn_red.Text = lbl_data + rbtn_red.Text;
        }

        private void rbtn_yellow_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_yellow.BackColor = Color.Yellow;
            rbtn_yellow.Text = lbl_data + rbtn_yellow.Text;
        }
    }
}
