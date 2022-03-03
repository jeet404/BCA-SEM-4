using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxEnabledDisabledTaskWinApp
{
    public partial class Form1 : Form
    {
        CheckBox[] itm = new CheckBox[10];
        public Form1()
        {
            InitializeComponent();
            itm[0] = chk_1;
            itm[1] = chk_2;
            itm[2] = chk_3;
            itm[3] = chk_4;
            itm[4] = chk_5;
            itm[5] = chk_6;
            itm[6] = chk_7;
            itm[7] = chk_8;
            itm[8] = chk_9;
            itm[9] = chk_10;
        }

        private void checkitem(object sender, EventArgs e)
        {
            int cnt = 0;
            foreach(CheckBox cb in itm)
            {
                if (cb.Checked)
                {
                    cnt++;
                }
            }
            if(cnt >= 5)
            {
                foreach (CheckBox cb in itm)
                {
                    if (!cb.Checked)
                    {
                        cb.Enabled = false;
                    }
                }
            }
            else if(cnt == 4)
            //else
            {
                foreach (CheckBox cb in itm)
                {
                    cb.Enabled = true;
                }
            }
        }
    }
}
