using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelDemoWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RadioButton rdo = new RadioButton();
            rdo.Name = "radiobutton5";
            rdo.Text = "radiobutton5";
            rdo.Location = new Point(3, 93);
            pnl_main.Controls.Add(rdo);
            pnl_main.AutoScroll = true;

        }
    }
}
