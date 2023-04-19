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
    public partial class fBSFood : Form
    {
        public fBSFood()
        {
            InitializeComponent();
        }

        void AddBestSelling() //add best selling for today
        {
            List<Dish> temp = Menu.Instance.GetMostSelling(Type.FOOD);
            if (temp != null)
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    Dish item = temp[i];
                    dtgvBSFood.Rows.Add(i, item.Name, item.NumberOfSells, item.NumberOfSells * (item.Price - item.ProdExpense));
                }
            }
        }
    }

}
