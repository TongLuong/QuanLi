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
    public partial class fBS : Form
    {
        public fBS()
        {
            InitializeComponent();
        }
        public void LoadData(List<Dish> dishes,string strName)
        {
            while (dtgvBS.Rows.Count > 1)
                dtgvBS.Rows.RemoveAt(1);

            foreach (Dish dish in dishes)
            {
                dtgvBS.Rows.Add(dish.Name, dish.NumberOfSells, (dish.Price - dish.ProdExpense) * dish.NumberOfSells);
            }
            this.Text = strName + " bán chạy nhất";
        }
    }
}
