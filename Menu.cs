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
        Others,
    }
    public class Dish
    {
        #region Feature
        int id; public int ID { get => id; set=> id = value; }
        string name; public string Name { get => name; set => name = value; }
        double price; public double Price { get => price; set => price = value; }
        double profit; public double Profit { get => profit; set => profit = value; }
        int numberOfSells; public int NumberOfSells { get => numberOfSells; set => numberOfSells = value; }
        Type type; public Type Type { get => type; set => type = value; }
        #endregion

        #region constructor
        public Dish(int id, string name, double price, double profit, Type type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.profit = profit;
            this.numberOfSells = 0;
            this.type = type;
        }
        #endregion
        #region overloading 
        public static bool operator !=(Dish A, Dish B)
        {
            return (A.numberOfSells != B.numberOfSells);
        }
        public static bool operator ==(Dish A, Dish B)
        {
            return (A.numberOfSells == B.numberOfSells);
        }
        public static bool operator >=(Dish A, Dish B)
        {
            return (A.numberOfSells >= B.numberOfSells);
        }
        public static bool operator <=(Dish A, Dish B)
        {
             return (A.numberOfSells <= B.numberOfSells);
        }
        public static bool operator <(Dish A, Dish B)
        {
            return (A.numberOfSells < B.numberOfSells);
        }
        public static bool operator >(Dish A, Dish B)
        {
            return (A.numberOfSells > B.numberOfSells);
        }
        public static Dish operator ++(Dish dish)
        {
            dish.numberOfSells++;
            return dish;
        }
        public static Dish operator --(Dish dish)
        {
            dish.numberOfSells--;
            return dish;
        }
        #endregion
        #region
        public void modify() //maybe create a button modify a dish if it exit or create a new dish if it's unavailable ??
        {

        }
        #endregion
    }
    public class Menu
    {
        #region feature
        List<Dish> foodList, drinkList, toppingList, othersList;
        public List<Dish> FoodList { get => foodList; set => foodList = value; }
        public List<Dish> DrinkList { get => drinkList; set => drinkList = value; }
        public List<Dish> ToppingList { get => toppingList; set => toppingList = value; }
        public List<Dish> OthersList { get => othersList; set => othersList = value; }
        int count; public int Count { get => count; set=> count = value; }
        #endregion
        #region constructor
        public Menu()
        {
            foodList = new List<Dish>();
            drinkList = new List<Dish>();
            toppingList = new List<Dish>();
            othersList = new List<Dish>();
            count = 0;
        }
        #endregion
        #region Functions
        public List<Dish> getListByType(Type type)
        {
            List<Dish> refList = othersList;
            switch (type)
            {
                case Type.Food:
                    refList = foodList;
                    break;
                case Type.Drink:
                    refList = drinkList;
                    break;
                case Type.Topping:
                    refList = toppingList;
                    break;
                case Type.Others:
                    refList = othersList;
                    break;
            }
            return refList;

        }
        public void AddDish(Dish dish) 
        {
            List<Dish> refList = getListByType(dish.Type);
            if(refList.Contains(dish))
            {
               
                MessageBox.Show("Available Dish !!");
            }
            else
            {
                refList.Add(dish);
                count++;
            }

        }

        public void RemoveDish(Dish dish)
        {
            List<Dish> refList = getListByType(dish.Type);
            if (refList.Contains(dish))
            {
                dish++;
            }
            else
            {
                MessageBox.Show("Unvailable dish !!");
            }
        }

        public void SortMenu(Type type) 
        {
            List<Dish> refList = getListByType(type);
            refList.Sort((a, b) => a > b ? -1 : 0); 
        }

        public void IncreaseSell(Dish dish)
        {
            List<Dish> refList = getListByType(dish.Type);
            if (refList.Contains(dish))
            {
                dish++;
            }
            else
            {
                MessageBox.Show("Unvailable dish !!");
            }
        }

        public void DecreaseSell(Dish dish)
        {
            List<Dish> refList = getListByType(dish.Type);
            if (refList.Contains(dish))
            {
                dish--;
            }
            else
            {
                MessageBox.Show("Unvailable dish !!");
            }
        }

        public double TotalSell()
        {
            double total = 0;
            List<Dish> dishes = foodList.Concat(drinkList).Concat(toppingList).Concat(othersList).ToList();
            IEnumerator<Dish> it = dishes.GetEnumerator();
            while (it.MoveNext())
            {
                Dish dish = it.Current;
                total = (dish.Profit)*dish.NumberOfSells + total;
            }
            return total;
        }
        public List<Dish> GetMostSelling()
        {
            if (count == 0) return null;
            List<Dish> dishes = foodList.Concat(drinkList).Concat(toppingList).Concat(othersList).ToList();
            IEnumerator<Dish> it = dishes.GetEnumerator ();
            List<Dish> mostSellingDishes = new List<Dish>();
            int mostSelling = 0;
            while(it.MoveNext())
            {
                Dish dish = it.Current;
                if (dish.NumberOfSells >= mostSelling)
                {
                    mostSellingDishes.Add(dish);
                    mostSelling = dish.NumberOfSells;
                }
                else
                {
                    break;
                }
            }
            return mostSellingDishes;
        }
        public List<Dish> GetMostSelling(Type type)
        {
            if (count == 0) return null;
            List<Dish> dishes = getListByType(type);
            IEnumerator<Dish> it = dishes.GetEnumerator();
            List<Dish> mostSellingDishes = new List<Dish>();
            int mostSelling = 0;
            while (it.MoveNext())
            {
                Dish dish = it.Current;
                if (dish.NumberOfSells >= mostSelling)
                {
                    mostSellingDishes.Add(dish);
                    mostSelling = dish.NumberOfSells;
                }
                else
                {
                    break;
                }
            }
            return mostSellingDishes;
        }
        #endregion
    }
}
