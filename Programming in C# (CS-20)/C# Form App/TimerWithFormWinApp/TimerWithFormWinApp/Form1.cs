using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerWithFormWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_main_Tick(object sender, EventArgs e)
        {
            if (pnl_main.BackColor == Color.White || pnl_main.BackColor == Color.Yellow)
            {
                pnl_main.BackColor = Color.Black;
                pnl_main.Size = new Size(510, 400);
            }
            else if (pnl_main.BackColor == Color.Black)
            {
                pnl_main.BackColor = Color.Coral;
                pnl_main.Size = new Size(560, 350);
            }
            else if (pnl_main.BackColor == Color.Coral)
            {
                pnl_main.BackColor= Color.Cyan;
                pnl_main.Size= new Size(560, 300);
            }
            else if (pnl_main.BackColor == Color.Cyan)
            {
                pnl_main.BackColor = Color.Pink;
                pnl_main.Size = new Size(560, 250);
            }
            else if (pnl_main.BackColor == Color.Pink)
            {
                pnl_main.BackColor = Color.Crimson;
                pnl_main.Size = new Size(560, 200);
            }
            else if (pnl_main.BackColor == Color.Crimson)
            {
                pnl_main.BackColor = Color.Blue;
                pnl_main.Size = new Size(560, 150);
            }
            else if (pnl_main.BackColor == Color.Blue)
            {
                pnl_main.BackColor = Color.Purple;
                pnl_main.Size = new Size(560, 100);
            }
            else if (pnl_main.BackColor == Color.Purple)
            {
                pnl_main.BackColor = Color.Red;
                pnl_main.Size = new Size(560, 50);
            }
            else if (pnl_main.BackColor == Color.Red)
            {
                pnl_main.BackColor = Color.Yellow;
                pnl_main.Size = new Size(560, 0);
                Dispose();
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            tmr_main.Start();
        }
    }
}
