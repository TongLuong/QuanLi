using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi
{
    public enum Type
    {
        Food,
        Drink,
        Topping,      
    }
    internal class Dish
    {
        //Features
        int id;
        string name;
        double price;
        double profit;
        int numberOfsells;
        Type type;

        //Constructor
        public Dish(int id, string name, double price, double profit, Type type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.profit = profit;
            this.numberOfsells = 0;
            this.type = type;
        }

        //overloading operator
        public static bool operator !=(Dish A, Dish B)
        {
            return (A.numberOfsells != B.numberOfsells);
        }
        public static bool operator ==(Dish A, Dish B)
        {
            return (A.numberOfsells == B.numberOfsells);
        }
        public static bool operator >=(Dish A, Dish B)
        {
            return (A.numberOfsells >= B.numberOfsells);
        }
        public static bool operator <=(Dish A, Dish B)
        {
             return (A.numberOfsells <= B.numberOfsells);
        }
        public static bool operator <(Dish A, Dish B)
        {
            return (A.numberOfsells < B.numberOfsells);
        }
        public static bool operator >(Dish A, Dish B)
        {
            return (A.numberOfsells > B.numberOfsells);
        }
        public static Dish operator ++(Dish dish)
        {
            dish.numberOfsells++;
            return dish;
        }
        public static Dish operator --(Dish dish)
        {
            dish.numberOfsells--;
            return dish;
        }

        //Function
        public void modify() //maybe create a button modify a dish if it exit or create a new dish if it's unavailable ??
        {

        }
    }
    internal class Menu
    {
        List<Dish> dishes;
        int count;
        public Menu()
        {
            dishes = new List<Dish>();
            count = 0;
        }
        public void addDish(Dish dish) 
        { 
            dishes.Add(dish);
            count++;
        }

        public void sortMenu() { dishes.Sort(); }

        public void increaseSell(Dish dish) { dish++; }
    }
}
