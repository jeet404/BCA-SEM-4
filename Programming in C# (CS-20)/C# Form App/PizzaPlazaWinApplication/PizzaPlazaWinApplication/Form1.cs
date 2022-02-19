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
        int parcel = 40;
        int small = 50;
        int mid = 150;
        int large = 300;
        int itm1, itm2, itm3, itm4;
        int qty1, qty2, qty3, qty4;

        private void item_2_CheckedChanged(object sender, EventArgs e)
        {
            if (item_2.Checked)
            {
                qty_2.Enabled = true;
                chk_parcel.Enabled = true;
            }
            else
            {
                qty_2.Enabled = false;
                chk_parcel.Enabled = false;
            }
        }

        private void item_3_CheckedChanged(object sender, EventArgs e)
        {
            if (item_3.Checked)
            {
                qty_3.Enabled = true;
                chk_parcel.Enabled = true;
            }
            else
            {
                qty_3.Enabled = false;
                chk_parcel.Enabled = false;
            }
        }

        private void item_4_CheckedChanged(object sender, EventArgs e)
        {
            if (item_4.Checked)
            {
                qty_4.Enabled = true;
                chk_parcel.Enabled = true;
            }
            else
            {
                qty_4.Enabled = false;
                chk_parcel.Enabled = false;
            }
        }

        private void item_1_CheckedChanged(object sender, EventArgs e)
        {
            if (item_1.Checked)
            {
                qty_1.Enabled = true;
                chk_parcel.Enabled = true;
            }
            else
            {
                qty_1.Enabled = false;
                chk_parcel.Enabled = false;
            }
        }

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

        private void qty_1_ValueChanged(object sender, EventArgs e)
        {
            if (chk_parcel.Checked)
            {
                if (chk_small.Checked)
                {
                    lbl_p1.Text = (qty_1.Value * small + parcel).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p1.Text = (qty_1.Value * mid + parcel).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p1.Text = (qty_1.Value * large + parcel).ToString();
                }
            }
            else
            {
                if (chk_small.Checked)
                {
                    lbl_p1.Text = (qty_1.Value * small).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p1.Text = (qty_1.Value * mid).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p1.Text = (qty_1.Value * large).ToString();
                }
            }
        }

        private void qty_2_ValueChanged(object sender, EventArgs e)
        {
            if (chk_parcel.Checked)
            {
                if (chk_small.Checked)
                {
                    lbl_p2.Text = (qty_2.Value * small + parcel).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p2.Text = (qty_2.Value * mid + parcel).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p2.Text = (qty_2.Value * large + parcel).ToString();
                }
            }
            else
            {
                if (chk_small.Checked)
                {
                    lbl_p2.Text = (qty_2.Value * small).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p2.Text = (qty_2.Value * mid).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p2.Text = (qty_2.Value * large).ToString();
                }
            }
        }

        private void qty_3_ValueChanged(object sender, EventArgs e)
        {
            if (chk_parcel.Checked)
            {
                if (chk_small.Checked)
                {
                    lbl_p3.Text = (qty_3.Value * small + parcel).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p3.Text = (qty_3.Value * mid + parcel).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p3.Text = (qty_3.Value * large + parcel).ToString();
                }
            }
            else
            {
                if (chk_small.Checked)
                {
                    lbl_p1.Text = (qty_3.Value * small).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p1.Text = (qty_3.Value * mid).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p1.Text = (qty_3.Value * large).ToString();
                }
            }
        }
        private void qty_4_ValueChanged(object sender, EventArgs e)
        {
            if (chk_parcel.Checked)
            {
                if (chk_small.Checked)
                {
                    lbl_p4.Text = (qty_4.Value * small + parcel).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p4.Text = (qty_4.Value * mid + parcel).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p4.Text = (qty_4.Value * large + parcel).ToString();
                }
            }
            else
            {
                if (chk_small.Checked)
                {
                    lbl_p4.Text = (qty_4.Value * small).ToString();
                }
                else if (chk_mid.Checked)
                {
                    lbl_p4.Text = (qty_4.Value * mid).ToString();
                }
                else if (chk_large.Checked)
                {
                    lbl_p4.Text = (qty_4.Value * large).ToString();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
