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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 1);
            this.TransparencyKey = Color.FromArgb(0, 0, 1);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
