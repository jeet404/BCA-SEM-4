using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinFormsApp
{
    public partial class Form1 : Form
    {

        int val1, val2, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val1 = Int32.Parse(txt_firstval.Text);
            val2 = Int32.Parse(txt_secondval.Text);
            if (txt_sign.Text == "+")
            {
                res = val1 + val2;
            }
            else if (txt_sign.Text == "-")
            {
                res = val1 - val2;
            }
            else if (txt_sign.Text == "*")
            {
                res = val1 * val2;
            }
            else if (txt_sign.Text == "/")
            {
                res = val1 / val2;
            }
            else
            {
                txt_ans.Text = "Enter Proper Sign.";
                ans_line.Text = "Enter Proper Sing";
            }
            txt_ans.Text = res.ToString();
            ans_line.Text = val1.ToString() + " " + txt_sign.Text + " " + val2.ToString() + " = " + res.ToString();
        }
    }
}
