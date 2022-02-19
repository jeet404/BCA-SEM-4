using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPlazaWinApplication
{
    public partial class Form1 : Form
    {

        int total = 0;
        int parcel = 0;
        int small = 50;
        int mid = 150;
        int large = 300;
        int itm1, itm2, itm3, itm4;
        int qty1, qty2, qty3, qty4;

        private void Form1_Shown(object sender, EventArgs e)
        {
            item_1.Enabled = false;
            item_2.Enabled = false;
            item_3.Enabled = false;
            item_4.Enabled = false;
            qty_1.Enabled = false;
            qty_2.Enabled = false;
            qty_3.Enabled = false;
            qty_4.Enabled = false;
            chk_parcel.Enabled = false;
        }

        private void chk_large_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_large.Checked)
            {
                item_1.Enabled = true;
                item_2.Enabled = true;
                item_3.Enabled = true;
                item_4.Enabled = true;
            }
            else
            {
                item_1.Enabled = false;
                item_2.Enabled = false;
                item_3.Enabled = false;
                item_4.Enabled = false;
            }
        }

        private void chk_mid_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mid.Checked)
            {
                item_1.Enabled = true;
                item_2.Enabled = true;
                item_3.Enabled = true;
                item_4.Enabled = true;
            }
            else
            {
                item_1.Enabled = false;
                item_2.Enabled = false;
                item_3.Enabled = false;
                item_4.Enabled = false;
            }
        }
        private void chk_small_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_small.Checked)
            {
                item_1.Enabled = true;
                item_2.Enabled = true;
                item_3.Enabled = true;
                item_4.Enabled = true;
            }
            else
            {
                item_1.Enabled = false;
                item_2.Enabled = false;
                item_3.Enabled = false;
                item_4.Enabled = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
