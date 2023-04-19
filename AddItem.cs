using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class AddItem : Form
    {
        private string name;
        public string itemName
        {
            get => name;
            set => name = value;
        }

        private double price;
        public double itemPrice
        {
            get => price;
            set => price = value;
        }

        private double expense;
        public double itemExpense
        {
            get => expense;
            set => expense = value;
        }

        public AddItem()
        {
            InitializeComponent();
            this.ActiveControl = Accept;
            name = null;
            price = 0;
            expense = 0;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            name = ItemName.Text;
            price = Convert.ToDouble(ItemPrice.Text);
            expense = Convert.ToDouble(ItemExpense.Text);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            ItemName.Text = "";
            ItemPrice.Text = "";
            ItemExpense.Text = "";
        }
    }
}
