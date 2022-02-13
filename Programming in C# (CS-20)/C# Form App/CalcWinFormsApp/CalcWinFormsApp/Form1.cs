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
            val1 = Int32.Parse(txt_val1.Text);
            val2 = Int32.Parse(txt_val2.Text);
            res = val1 + val2;
            txt_answer.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            val1 = Int32.Parse(txt_val1.Text);
            val2 = Int32.Parse(txt_val2.Text);
            res = val1 - val2;
            txt_answer.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            val1 = Int32.Parse(txt_val1.Text);
            val2 = Int32.Parse(txt_val2.Text);
            res = val1 * val2;
            txt_answer.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            val1 = Int32.Parse(txt_val1.Text);
            val2 = Int32.Parse(txt_val2.Text);
            res = val1 / val2;
            txt_answer.Text = res.ToString();
        }

        public static bool chk(int n)
        {
            return (n % 2 == 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            val1 = Int32.Parse(txt_val1.Text);
            if (chk(val1) == true)
            {
                txt_val1.Text = val1 + " Even";
            }
            else
            {
                txt_val1.Text = val2 + " Odd";
            }
            val2 = Int32.Parse(txt_val2.Text);
            if (chk(val2) == true)
            {
                txt_val2.Text = val2 + " Evan";
            }
            else
            {
                txt_val2.Text = val2 + " Odd";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            val1 = Int32.Parse(txt_val1.Text);
            val2 = Int32.Parse(txt_val2.Text);

            if (val1 < val2)
            {
                txt_answer.Text = Convert.ToString(val1) + " = Min /" + Convert.ToString(val2) + " = Max";
            }
            else if (val1 > val2)
            {
                txt_answer.Text = Convert.ToString(val1) + " = Max /" + Convert.ToString(val2) + " = Min";
            }
            else
            {
                txt_answer.Text = "Same";
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
