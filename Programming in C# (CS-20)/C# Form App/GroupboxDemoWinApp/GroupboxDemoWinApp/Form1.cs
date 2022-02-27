using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupboxDemoWinApp
{
    public partial class Form1 : Form
    {
        string line = "";
        string[] gender = new string[] {"Male","Female"};
        string[] cat = new string[] { "General", "OBC", "ST", "SC" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if(rdo_Male.Checked)
            {
                if(rdo_gen.Checked)
                {
                    line = "U are "+gender[0]+" Your category is "+cat[0];
                }
                else if(rdo_obc.Checked)
                {
                    line = "U are "+gender[0]+" Your category is "+cat[1];
                }
                else if(rdo_st.Checked)
                {
                    line = "U are "+gender[0]+" Your category is "+cat[2];
                }
                else if(rdo_sc.Checked)
                {
                    line = "U are "+gender[0]+" Your category is "+cat[3];
                }
            }
            else if(rdo_Female.Checked)
            {
                if (rdo_gen.Checked)
                {
                    line = "U are "+gender[1]+" Your category is "+cat[0];
                }
                else if (rdo_obc.Checked)
                {
                    line = "U are "+gender[1]+" Your category is "+cat[1];
                }
                else if (rdo_st.Checked)
                {
                    line = "U are "+gender[1]+" Your category is "+cat[2];
                }
                else if (rdo_sc.Checked)
                {
                    line = "U are "+gender[1]+" Your category is "+cat[3];
                }
            }
            lbl_data.Text = line;
        }
    }
}
