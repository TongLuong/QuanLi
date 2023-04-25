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
    public partial class fBSSpecial : Form
    {
        public fBSSpecial()
        {
            InitializeComponent();
        }

        public void LoadData(List<Dish> dishes)
        {
            while (dtgvBSSpecial.Rows.Count > 1)
                dtgvBSSpecial.Rows.RemoveAt(1);

            foreach (Dish dish in dishes)
            {
                dtgvBSSpecial.Rows.Add(dish.Name, dish.NumberOfSells, (dish.Price - dish.ProdExpense) * dish.NumberOfSells);
            }
        }
    }
}
