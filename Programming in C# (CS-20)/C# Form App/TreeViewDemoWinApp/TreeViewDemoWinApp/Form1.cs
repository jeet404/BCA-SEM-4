using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewDemoWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode node;
            node = treeView1.Nodes.Add("Cars");
            node.Nodes.Add("BMW");
            node.Nodes.Add("Lexus");
            node = treeView1.Nodes.Add("Bikes");
            node.Nodes.Add("Panigale V4");
            node.Nodes.Add("Ninja ZX-10R");
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            treeView1.Sort();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btn_coll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
