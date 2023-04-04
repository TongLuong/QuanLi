using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1Button_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form1Button_Click(object sender, EventArgs e)
        {

        }
    }
}
