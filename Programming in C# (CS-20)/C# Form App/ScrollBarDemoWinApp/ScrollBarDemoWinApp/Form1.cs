using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBarDemoWinApp
{
    public partial class Form1 : Form
    {
        int min = 0;
        int max = 1000;
        int lChange = 50;
        int sChange = 15;
        int totval = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txt_min.Text = min.ToString();
            txt_max.Text = max.ToString();
            txt_lchange.Text = lChange.ToString();
            txt_schange.Text = sChange.ToString();
            txt_val.Text = totval.ToString();
            hsb_main.Focus();
        }

        private void hsb_main_Scroll(object sender, ScrollEventArgs e)
        {
            txt_val.Text = hsb_main.Value.ToString();
        }
    }
}
