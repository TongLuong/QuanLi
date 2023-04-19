using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBestSellingDrink_Click(object sender, EventArgs e)
        {
            fBSDrink f = new fBSDrink();
            f.ShowDialog();
        }

        private void btnBestSellingFood_Click(object sender, EventArgs e)
        {
            fBSFood f = new fBSFood();
            f.ShowDialog();
        }

        private void btnBestSellingTopping_Click(object sender, EventArgs e)
        {
            fBSTopping f = new fBSTopping();
            f.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            lbDate.Text = "Ngày " + today.ToString("dd/MM/yyyy");
        }

        //void LoadStatistics()
        //{
        //    List<Dish> dishes = Menu.Instance.
        //}
    }
}
