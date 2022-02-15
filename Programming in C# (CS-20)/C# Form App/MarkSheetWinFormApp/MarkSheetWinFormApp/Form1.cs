using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkSheetWinFormApp
{
    public partial class Form1 : Form
    {
        int cs, java, os, net;
        int total = 0;
        float per = 0;
        string grade = "";
        string newline = Environment.NewLine;

        private void button1_TextChanged(object sender, EventArgs e)
        {
            if(txt_rno.Text == "")
            {
                txt_rno.Focus();
            }
            else if(txt_studname.Text == "")
            {
                txt_studname.Focus();
            }
            else if(txt_cs.Text == "")
            {
                txt_cs.Focus();
            }
            else if(txt_java.Text == "")
            {
                txt_java.Focus();
            }
            else if(txt_os.Text == "")
            {
                txt_os.Focus();
            }
            else if(txt_net.Text == "")
            {
                txt_net.Focus();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs = Int32.Parse(txt_cs.Text);
            java = Int32.Parse(txt_java.Text);
            os = Int32.Parse(txt_os.Text);
            net = Int32.Parse(txt_net.Text);

            total = cs + java + os + net;
            per = (total / 4);
            if (per >= 80)
            {
                grade = "A+";
            }
            else if (per >= 70)
            {
                grade = "A";
            }
            else if (per >= 60)
            {
                grade = "B";
            }
            else if (per >= 35)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }

            txt_result.Text = "Roll No : " +txt_rno.Text+newline+"Student Name : "+txt_studname.Text+newline+"-------------------------------"+newline+"C#     "+cs+newline+"JAVA    "+java+newline+"OS    "+os+newline+"Network   "+net+newline+"-------------------------------"+newline+"Obtained Marks : "+total+newline+"Percentage : "+per+newline+"Grade : "+grade+newline+"-------------------------------";
        }
    }
}
