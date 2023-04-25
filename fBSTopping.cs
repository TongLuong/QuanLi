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
    public partial class fBSTopping : Form
    {
        public fBSTopping()
        {
            InitializeComponent();
        }

        public void LoadData(List<Dish> dishes)
        {
            while (dtgvBSTopping.Rows.Count > 1)
                dtgvBSTopping.Rows.RemoveAt(1);

            foreach (Dish dish in dishes)
            {
                dtgvBSTopping.Rows.Add(dish.Name, Image.FromFile(dish.GetImagePath()), dish.NumberOfSells, (dish.Price - dish.ProdExpense) * dish.NumberOfSells);
            }
        }
    }
}
