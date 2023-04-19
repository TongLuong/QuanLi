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

        private Type type;
        public Type itemType
        {
            get => type;
            set => type = value;
        }

        private bool abort;
        public bool Abort
        {
            get => abort;
        }

        public AddItem()
        {
            InitializeComponent();
            this.ActiveControl = Accept;
            name = null;
            price = 0;
            expense = 0;
            type = Type.NONE;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            name = ItemName.Text;
            try
            {
                price = Convert.ToDouble(ItemPrice.Text);
                expense = Convert.ToDouble(ItemExpense.Text);
            }
            catch (Exception exc)
            {
                if (exc is FormatException)
                    MessageBox.Show(exc.Message + "\n" + "Please enter number only!");
                else if (exc is OverflowException)
                    MessageBox.Show(exc.Message + "\n" + "The number is too large!");

                return;
            }

            Enum.TryParse(ItemType.SelectedItem.ToString(), out type);

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            abort = true;
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            ItemName.Text = "";
            ItemPrice.Text = "";
            ItemExpense.Text = "";

            if (ItemType.Items.Count == 0)
            {
                foreach (string t in Enum.GetNames(typeof(Type)))
                {
                    ItemType.Items.Add(t);
                }
            }
            ItemType.SelectedIndex = 0;
        }
    }
}
