using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassageDialogBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_msg_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are You Sure ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show("U have Pressed Yes");
            }
            else
            {
                MessageBox.Show("U have Pressed No");
            }
        }
    }
}
