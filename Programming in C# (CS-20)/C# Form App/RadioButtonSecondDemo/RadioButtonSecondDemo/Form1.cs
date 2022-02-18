using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonSecondDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            string lbl_data = "U have Selected : ";
            if(rbtn_red.Checked == true)
            {
                lbl_selected.BackColor = Color.Red;
                lbl_selected.Text = lbl_data +" "+ rbtn_red.Text;
            }
            else if (rbtn_yellow.Checked == true)
            {
                lbl_selected.BackColor = Color.Yellow;
                lbl_selected.Text = lbl_data +" "+ rbtn_yellow.Text;
            }
            else if (rbtn_blue.Checked == true)
            {
                lbl_selected.BackColor = Color.Blue;
                lbl_selected.Text = lbl_data +" "+ rbtn_blue.Text;
            }
        }
    }
}
