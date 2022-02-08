using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            txt_third.Text=txt_first.Text;
            txt_fourth.Text=txt_second.Text;
        }

        private void txt_first_Leave(object sender, EventArgs e)
        {
            txt_second.Text="Bye";
            txt_first.Text="Hello";
        }

        private void txt_second_Leave(object sender, EventArgs e)
        {
            txt_first.Text="Bye";
            txt_second.Text="Hello";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Show();
            button5.SendToBack(); 
            button2.BringToFront(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            button2.SendToBack();
            button5.BringToFront();
        }
    }
}
