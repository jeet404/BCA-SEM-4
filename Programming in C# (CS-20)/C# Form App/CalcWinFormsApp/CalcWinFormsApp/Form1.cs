using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinFormsApp
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
            val1 = int.Parse(txt_val1.Text);
            val2 = int.Parse(txt_val2.Text);
            res = val1 + val2;
            txt_answer.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            val1 = int.Parse(txt_val1.Text);
            val2 = int.Parse(txt_val2.Text);
            res = val1 - val2;
            txt_answer.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            val1 = int.Parse(txt_val1.Text);
            val2 = int.Parse(txt_val2.Text);
            res = val1 * val2;
            txt_answer.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            val1 = int.Parse(txt_val1.Text);
            val2 = int.Parse(txt_val2.Text);
            res = val1 / val2;
            txt_answer.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            val1 = int.Parse(txt_val1.Text);
            val2 = int.Parse(txt_val2.Text);

            if (val1 % 2 == 0 || )
            {
                if (val1 % 2 == 0)
                {
                    txt_val1.Text = val2 + " Even";
                }
                else
                {
                    txt_val1.Text = val1 + " Odd";
                }
            }
            else
            {
                if (val1 % 1 == 0)
                {
                    txt_val1.Text = val1 + " Odd";
                }
                else
                {
                    txt_val2.Text = val2 + " Odd";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_answer.Clear();
            txt_val1.Clear();
            txt_val2.Clear();
        }
    }
}
