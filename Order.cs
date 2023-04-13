using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public class Order
    {
        string name; public string Name { get => name; }
        double price; public double Price { get => price; }
        public Order(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
    public class Bill
    {
        #region Feature
        List<KeyValuePair<Order, int>> orders; public List<KeyValuePair<Order, int>> Orders { get => orders; set => orders = value; }
        double total; public double Total { get => total; set => total = value; }
        #endregion
        #region Constructor
        public Bill() 
        {
            orders = new List<KeyValuePair<Order, int>>();
            total = 0;
        }
        #endregion
        #region Function
        
        public void ModifyBill(FlowLayoutPanel listOrderName, FlowLayoutPanel listOrderAmount, FlowLayoutPanel listOrderPrice)
        {
            List<Control> name = listOrderName.Controls.OfType<Control>().ToList();
            List<Control> amount = listOrderAmount.Controls.OfType<Control>().ToList();
            List<Control> price = listOrderPrice.Controls.OfType<Control>().ToList();
            int size = name.Count();
            for(int i = 0; i < size; i++)
            {
                string  newName = name[i].Text.ToString();
                int  newAmount = Convert.ToInt32(amount[i].Text);
                double newPrice = Convert.ToDouble(price[i].Text);
                Order tmp = new Order(newName, newPrice);
                KeyValuePair<Order, int> newOrder = new KeyValuePair<Order, int>(tmp,newAmount);
                orders.Add(newOrder);
                total += newAmount * newPrice;
            }

        }
        #endregion
    }

    public class ListBill
    {
        List<Bill> bills; public List<Bill> Bills { get => bills; set => bills = value; }
        public static ListBill Instance { get; set; }
        
        public ListBill()
        {
            bills = new List<Bill>();
            Instance = this;
        }
        public void AddBill(Bill bill)
        {
            bills.Add(bill);
        }
    }
}
