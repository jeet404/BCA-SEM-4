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
        string comSpace = "     ";     

        private void Form1_Shown(object sender, EventArgs e)
        {
            txt_rno.Focus();
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

            txt_result.Text = "Roll No : "+comSpace+txt_rno.Text+newline+"Student Name : "+comSpace+txt_studname.Text+newline+"-------------------------------"+newline+"C#"+comSpace+cs+newline+"JAVA"+comSpace+java+newline+"OS"+comSpace+os+newline+"Network"+comSpace+net+newline+"-------------------------------"+newline+"Obtained Marks :"+comSpace+total+newline+"Percentage :"+comSpace+per+newline+"Grade :"+comSpace+grade+newline+"-------------------------------";
        }
    }
}
