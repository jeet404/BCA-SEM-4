using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxDemo2WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                lbl_data.Text = "India";
            }
            else if(checkBox2.Checked)
            {
                lbl_data.Text = "England";
            }
            else if(checkBox3.Checked)
            {
                lbl_data.Text = "Australia";
            }
        }
    }
}
