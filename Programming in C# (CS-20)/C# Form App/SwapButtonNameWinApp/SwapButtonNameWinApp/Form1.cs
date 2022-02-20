using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwapButtonNameWinApp
{
    public partial class Form1 : Form
    {
        string btn1;
        string btn2;
        string btn3;
        string btn4;
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_first_Click(object sender, EventArgs e)
        {
            btn1 = btn_first.Text;
            btn2 = btn_second.Text;
            btn3 = btn_third.Text;
            btn4 = btn_fourth.Text;
            btn_first.Text = btn4;
            btn_second.Text = btn1;
            btn_third.Text = btn2;
            btn_fourth.Text = btn3;
        }

        private void btn_second_Click(object sender, EventArgs e)
        {
            btn1 = btn_first.Text;
            btn2 = btn_second.Text;
            btn3 = btn_third.Text;
            btn4 = btn_fourth.Text;
            btn_first.Text = btn4;
            btn_second.Text = btn1;
            btn_third.Text = btn2;
            btn_fourth.Text = btn3;
        }

        private void btn_third_Click(object sender, EventArgs e)
        {
            btn1 = btn_first.Text;
            btn2 = btn_second.Text;
            btn3 = btn_third.Text;
            btn4 = btn_fourth.Text;
            btn_first.Text = btn4;
            btn_second.Text = btn1;
            btn_third.Text = btn2;
            btn_fourth.Text = btn3;
        }

        private void btn_fourth_Click(object sender, EventArgs e)
        {
            btn1 = btn_first.Text;
            btn2 = btn_second.Text;
            btn3 = btn_third.Text;
            btn4 = btn_fourth.Text;
            btn_first.Text = btn4;
            btn_second.Text = btn1;
            btn_third.Text = btn2;
            btn_fourth.Text = btn3;
        }
    }
}
