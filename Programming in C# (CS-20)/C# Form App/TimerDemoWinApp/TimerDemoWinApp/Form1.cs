using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerDemoWinApp
{
    public partial class Form1 : Form
    {
        int ival = 0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            tmr_main.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tmr_main.Stop();
        }

        private void tmr_main_Tick(object sender, EventArgs e)
        {
            ival = ival + tmr_main.Interval;
            if(ival == 1000)
            { 
                lbl_wait.Visible = false;
                lbl_stop.Visible = true;
                lbl_status.Text = "Stop";
            }
            else if(ival == 2000)
            {
                lbl_start.Visible = true;
                lbl_stop.Visible = false;
                lbl_status.Text = "Start";
            }
            else if(ival == 3000)
            {
                lbl_wait.Visible = true;
                lbl_start.Visible = false ;
                lbl_stop.Visible = false ;
                lbl_status.Text = "Wait";
                ival = 0;
            }
        }
    }
}
