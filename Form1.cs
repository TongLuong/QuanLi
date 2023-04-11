using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Order_Click(object sender, EventArgs e)
        {
            Label temp = new Label();
            temp.Text = "this is a very long textttttt";
            temp.AutoSize = true;

            flowOrderName.Controls.Add(temp);
            flowOrderName.SetFlowBreak(temp, true);
        }
    }
}
