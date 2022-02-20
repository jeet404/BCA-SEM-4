using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxDemoWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lbl_data.Text = "Cricket Checked";
            }
            else
            {
                lbl_data.Text = "Cricket Unchecked";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                lbl_data.Text = "Hockey Checked";
            }
            else
            {
                lbl_data.Text = "Hockey Unchecked";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                lbl_data.Text = "Football Checked";
            }
            else
            {
                lbl_data.Text = "Football Unchecked";
            }
        }
    }
}
