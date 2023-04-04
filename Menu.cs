using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLi
{
    public enum Type
    {
        Food,
        Drink,
        Topping,      
    }
    public class Dish
    {
        //Features
        public int id;
        public string name;
        public double price;
        public double profit;
        public int numberOfsells;
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

        public override bool Equals(Object obj)
        {
            Dish d = obj as Dish;
            if (d != null) 
            {
                return d.numberOfsells == this.numberOfsells;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return numberOfsells + id * 10;
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
    public class Menu
    {
        public List<Dish> dishes;
        public int count;
        public Menu()
        {
            dishes = new List<Dish>();
            count = 0;
        }
        public void addDish(Dish dish) 
        {
            if (dishes.Contains(dish))
            {
                MessageBox.Show("The existing dish !!");
                return;
            }
            dishes.Add(dish);
            count++;
        }

        public void removeDish(Dish dish)
        {
            if (!dishes.Contains(dish))
            {
                MessageBox.Show("Unavailable dish !!");
                return;
            }
            dishes.Remove(dish);
            count--;
        }

        public void sortMenu() { dishes.Sort((a, b) => a > b ? -1 : 0); }

        public void increaseSell(Dish dish)
        {
            if (dishes.Contains(dish))
            {
                dish++;
            }
            else
            {
                MessageBox.Show("Unvailable dish !!");
            }
        }

        public void decreaseSell(Dish dish)
        {
            if (dishes.Contains(dish))
            {
                dish--;
            }
            else
            {
                MessageBox.Show("Unvailable dish !!");
            }
        }

        public double totalSell()
        {
            double total = 0;
            IEnumerator<Dish> it = dishes.GetEnumerator();
            while (it.MoveNext())
            {
                Dish dish = it.Current;
                total = (dish.profit)*dish.numberOfsells + total;
            }
            return total;
        }
        public List<Dish> getMostSelling()
        {
            if (count == 0) return dishes;
            IEnumerator<Dish> it = dishes.GetEnumerator ();
            List<Dish> mostSellingDishes = new List<Dish>();
            int mostSelling = 0;
            while(it.MoveNext())
            {
                Dish dish = it.Current;
                if (dish.numberOfsells >= mostSelling)
                {
                    mostSellingDishes.Add(dish);
                    mostSelling = dish.numberOfsells;
                }
                else
                {
                    break;
                }
            }
            return mostSellingDishes;
        }
    }
}
