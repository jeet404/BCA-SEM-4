using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddRemoveItemComboBoxWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            combo_done.Items.Remove(combo_done.Text);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(combo_done.Items.Contains(txt_add.Text))
            {
                lbl_warning.Text = "Item Already Exist";
            }
            else
            { 
                combo_done.Items.Add(txt_add.Text);
                txt_add.Text = " ";
                txt_add.Focus();
            }
        }

        private void txt_add_TextChanged(object sender, EventArgs e)
        {
            lbl_warning.Text = "";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txt_add.Focus();
        }
    }
}
