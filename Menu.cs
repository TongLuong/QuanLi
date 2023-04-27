using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace QuanLi
{
    public enum Type
    {
        NONE,
        FOOD,
        DRINK,
        TOPPING,
        SPECIAL,
    }
    public class Dish 
    {
        private string path = "";
        #region Feature
        string id; public string ID { get => id; set=> id = value; }
        string name; public string Name { get => name; set => name = value; }
        double price; public double Price { get => price; set => price = value; }
        double prodExpense; public double ProdExpense { get => prodExpense; set => prodExpense = value; }
        int numberOfSells; public int NumberOfSells { get => numberOfSells; set => numberOfSells = value; }
        Type type; public Type Type { get => type; set => type = value; }
        string imageName; public string ImageName { get=> imageName; set => imageName = value; }
        string time; public string Time { get =>  time; set => time = value; }
        #endregion

        #region constructor

        public Dish(string id, string name, double price, double prodExpense, int numberOfSells, Type type, string imageName, string time = "")
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.prodExpense = prodExpense;
            this.numberOfSells = numberOfSells;
            this.type = type;
            this.imageName = imageName;
            this.time = time;

            InitImagePath();
        }

        public Dish(string name, double price, double prodExpense, Type type, string imageName)
        {
            this.id = NewId().ToString();
            this.name = name;
            this.price = price;
            this.prodExpense = prodExpense;
            this.numberOfSells = 0;
            this.type = type;
            this.ImageName = imageName;

            InitImagePath();
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

        public override int GetHashCode()
        {
            return NumberOfSells + Convert.ToInt32(id) * 10;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else if (ReferenceEquals(obj, null))
                return false;
            else
                return false;
        }

        public static Dish operator +(Dish dish, int val)
        {
            dish.numberOfSells += val;
            return dish;
        }

        public static Dish operator -(Dish dish, int val)
        {
            dish.numberOfSells -= val;
            return dish;
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
        #region Function
        private long NewId()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        private void InitImagePath()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int index = baseDir.IndexOf("bin");
            path = baseDir.Substring(0, index) + "Images\\Form1\\";
        }

        public string GetImagePath()
        {
            return path + imageName;
        }
        #endregion
    }
    public class Menu
    {
        #region feature
        private static Menu instance = null; //singleTon here

        List<Dish> foodList, drinkList, toppingList, specialList;
        public List<Dish> FoodList { get => foodList; set => foodList = value; }
        public List<Dish> DrinkList { get => drinkList; set => drinkList = value; }
        public List<Dish> ToppingList { get => toppingList; set => toppingList = value; }
        public List<Dish> SpecialList { get => specialList; set => specialList = value; }
        int count; public int Count { get => count; set => count = value; }
        #endregion
        #region constructor
        private Menu()
        {
            foodList = new List<Dish>();
            drinkList = new List<Dish>();
            toppingList = new List<Dish>();
            specialList = new List<Dish>();

            LoadFromDatabase();
            count = 0;
        }

        public static Menu Instance
        {
            get
            {
                if(instance == null) instance = new Menu();
                return instance;
            }
        }

        #endregion
        #region Functions

        private void LoadFromDatabase()
        {
            List<Dish> all = Database.Instance.ReadCSVToList<Dish>();

            IEnumerator<Dish> enumerator = all.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Dish dish = enumerator.Current;
                switch(dish.Type)
                {
                    case Type.NONE:
                        break;
                    case Type.FOOD:
                        FoodList.Add(dish);
                        break;
                    case Type.DRINK:
                        DrinkList.Add(dish);
                        break;
                    case Type.TOPPING:
                        ToppingList.Add(dish);
                        break;
                    case Type.SPECIAL:
                        SpecialList.Add(dish);
                        break;
                }
            }
        }

        public List<Dish> getListByType(Type type)
        {
            List<Dish> refList = null;
            switch (type)
            {
                case Type.FOOD:
                    refList = foodList;
                    break;
                case Type.DRINK:
                    refList = drinkList;
                    break;
                case Type.TOPPING:
                    refList = toppingList;
                    break;
                case Type.SPECIAL:
                    refList = specialList;
                    break;
            }
            return refList;

        }
        public bool AddDish(Dish dish)
        {
            if(dish.Type == Type.NONE)
            {
                MessageBox.Show("Unvalid Type !");
                return false;
            }
            List<Dish> refList = getListByType(dish.Type);
            IEnumerator<Dish> it = refList.GetEnumerator();
            while (it.MoveNext())
            {
                if(it.Current.Name == dish.Name)
                {
                    MessageBox.Show("Available Dish !!");
                    return false;
                }
            }
            refList.Add(dish);
            count++;
            return true;
        }

        public bool RemoveDish(Dish dish)
        {
            List<Dish> refList = getListByType(dish.Type);
            IEnumerator<Dish> it = refList.GetEnumerator();
            while (it.MoveNext())
            {
                if (it.Current.Name == dish.Name)
                {
                    refList.Remove(dish);
                    count--;
                    return true;
                }
            }
            MessageBox.Show("Unvailable dish !!");
            return false;
        }
        public double TotalProdExpense()
        {
            double total = 0;
            List<Dish> dishes = foodList.Concat(drinkList).Concat(toppingList).Concat(specialList).ToList();
            IEnumerator<Dish> it = dishes.GetEnumerator();
            while (it.MoveNext())
            {
                Dish dish = it.Current;
                total = (dish.ProdExpense) *dish.NumberOfSells + total;
            }
            return total;
        }

        public double TotalIncome()
        {
            double total = 0;
            List<Dish> dishes = foodList.Concat(drinkList).Concat(toppingList).Concat(specialList).ToList();
            IEnumerator<Dish> it = dishes.GetEnumerator();
            while (it.MoveNext())
            {
                Dish dish = it.Current;
                total = (dish.Price) * dish.NumberOfSells + total;
            }
            return total;

        }
        public List<Dish> GetMostSelling(Type type,List<Dish> mostSellingDishes)
        {
            mostSellingDishes.Clear();
            List<Dish> dishes = getListByType(type);
            if(dishes.Count == 0) { return mostSellingDishes; }
            dishes.Sort((a, b) => a > b ? -1 : 0);
            IEnumerator<Dish> it = dishes.GetEnumerator();
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
        public List<Dish> GetAllDishes()
        {
            return foodList.Concat(drinkList).Concat(toppingList).Concat(specialList).ToList();
        }
        #endregion
    }
}
