using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDemoWinApp
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!lst_left.Items.Contains(txt_add.Text))
            {
                lst_left.Items.Add(txt_add.Text);
                txt_add.Text = null;
                txt_add.Focus();
            }
        }

        private void btn_all_right_Click(object sender, EventArgs e)
        {
            // With while loop
            while (lst_left.Items.Count > 0)
            {
                lst_right.Items.Add(lst_left.Items[0]);
                lst_left.Items.RemoveAt(0);
            }

            // With for loop
            /*int cnt = lst_left.Items.Count;
            for (int i = 0; i < cnt; i++)
            {
                lst_right.Items.Add(lst_left.Items[0]);
                lst_left.Items.RemoveAt(0);
            }*/
        }

        private void btn_all_copy_right_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_left.Items.Count; i++)
            {
                lst_right.Items.Add(lst_left.Items[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_left.Items.Clear();
            lst_right.Items.Clear();
        }

        private void btn_sel_right_Click(object sender, EventArgs e)
        {
            while (lst_left.SelectedItems.Count > 0)
            {
                string line = lst_left.SelectedItems[0].ToString();
                lst_right.Items.Add(line);
                lst_left.Items.Remove(line);
            }
        }

        private void btn_all_left_Click(object sender, EventArgs e)
        {
            while (lst_right.Items.Count > 0)
            {
                lst_left.Items.Add(lst_right.Items[0]);
                lst_right.Items.RemoveAt(0);
            }
        }

        private void btn_sel_left_Click(object sender, EventArgs e)
        {
            while (lst_right.SelectedItems.Count > 0)
            {
                string line = lst_right.SelectedItems[0].ToString();
                lst_left.Items.Add(line);
                lst_right.Items.Remove(line);
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Dispose();
        }
    }
}
