﻿using System;
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
            timer1.Start();
        }

        private void Form1Button_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.MouseOverBackColor = ((Button)sender).BackColor;
            this.MenuButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenuHover));
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            this.MenuButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Menu));
        }

        private void MenuButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MenuButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenuDown));
            this.MenuButton.FlatAppearance.MouseDownBackColor = this.MenuButton.BackColor;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }

        private void RevenueButton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.MouseOverBackColor = ((Button)sender).BackColor;
            this.RevenueButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RevenueHover));
        }

        private void RevenueButton_MouseLeave(object sender, EventArgs e)
        {
            this.RevenueButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Revenue));
        }

        private void RevenueButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.RevenueButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RevenueDown));
            this.RevenueButton.FlatAppearance.MouseDownBackColor = this.MenuButton.BackColor;
        }

        private void RevenueButton_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
