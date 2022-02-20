using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringOperationsWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
                txt_one.SelectAll();
                Clipboard.SetText(txt_one.Text);
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            if(txt_one.Text != null)
            {
                txt_one.SelectAll();
                Clipboard.SetText(txt_one.Text);
                txt_one.Clear();
            }
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            if(txt_two.Text != null)
            {
                txt_two.Text = Clipboard.GetText();
            }
            else
            {
                txt_two.Clear();
                txt_two.Text = Clipboard.GetText();
            }
        }

        private void btn_append_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            string data = txt_one.Text;
            txt_two.AppendText(newline+data);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_one.Clear();
        }
    }
}
