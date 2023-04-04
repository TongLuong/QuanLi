using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi
{
    internal class Food
    {
        int id;
        string name;
        double price;
        double profit;
        int numberOfsells;
        public Food(int id, string name, double price, double profit)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.profit = profit;
            this.numberOfsells = 0;
        }

        public void increaseSell() { this.numberOfsells++; }

    }
}
