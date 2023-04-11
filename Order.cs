using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi
{
    public class Order
    {
        string name;
        double price;
        Order(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
    public class Bill
    {
        #region Feature
        List<KeyValuePair<Order, int>> orders; public List<KeyValuePair<Order, int>> Orders { get => orders; set => orders = value; }
        #endregion
        #region Constructor
        public Bill() 
        {
            orders = new List<KeyValuePair<Order, int>>();
        }
        #endregion
        #region Function
        
        public void ModifyBill()
        {

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
    }
}
