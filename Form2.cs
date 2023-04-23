using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using System.Diagnostics;

namespace QuanLi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ChartInitialize();
        }

        #region lists
        List<Dish> all = new List<Dish>();
        List<Dish> food = new List<Dish>();
        List<Dish> drink = new List<Dish>();
        List<Dish> topping = new List<Dish>();
        List<Dish> special = new List<Dish>();
        #endregion

        #region best selling forms
        fBSFood foodForm = null;
        fBSDrink drinkForm = null;
        fBSTopping toppingForm = null;
        fBSSpecial specialForm = null;
        #endregion

        private void btnBestSellingDrink_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBestSellingFood_Click(object sender, EventArgs e)
        {
            if (foodForm == null)
            {
                foodForm = new fBSFood();
                foodForm.ShowDialog();
            }
        }

        private void btnBestSellingTopping_Click(object sender, EventArgs e)
        {
            fBSTopping f = new fBSTopping();
            f.ShowDialog();
        }

        private void btnBestSellingSpecial_Click(object sender, EventArgs e)
        {
            fBSSpecial f = new fBSSpecial();
            f.ShowDialog();
        }

        private void dropdownButton_Click(object sender, EventArgs e)
        {
            dropdownTimer.Start();
            //HandleDropdown();
        }
        bool listOpened = false;
        private void dropdownTimer_Tick(object sender, EventArgs e)
        {
            if (listOpened)
            {
                dropdownPanel.Height -= 30;
                if (dropdownPanel.Size == dropdownPanel.MinimumSize)
                {
                    dropdownTimer.Stop();
                    listOpened = false;
                }
            }
            else
            {
                dropdownPanel.Height += 30;
                if (dropdownPanel.Size == dropdownPanel.MaximumSize)
                {
                    dropdownTimer.Stop();
                    listOpened = true;
                }
            }
        }

        void HandleDropdown()
        {
            while (true)
            {
                dropdownPanel.Invoke(new Action(() =>
                    {
                        if (listOpened)
                        {
                            dropdownPanel.Height -= 40;
                            if (dropdownPanel.Size == dropdownPanel.MinimumSize)
                            {
                                listOpened = false;
                                return;
                            }
                        }
                        else
                        {
                            dropdownPanel.Height += 40;
                            if (dropdownPanel.Size == dropdownPanel.MaximumSize)
                            {
                                listOpened = true;
                                return;
                            }
                        }
                    }));


                Thread.Sleep(100);
            }
        }


        private void todayButton_Click(object sender, EventArgs e)
        {
            all = Menu.Instance.getListByType(QuanLi.Type.FOOD).Concat(Menu.Instance.getListByType(QuanLi.Type.DRINK)).Concat(Menu.Instance.getListByType(QuanLi.Type.TOPPING)).Concat(Menu.Instance.getListByType(QuanLi.Type.SPECIAL)).ToList();

            foreach (Dish dish in all)
            {
                dtgvStatistic.Rows.Add(
                    dish.Name,
                    dish.Type.ToString(),
                    dish.NumberOfSells,
                    dish.Price * dish.NumberOfSells,
                    (dish.Price - dish.ProdExpense) * dish.NumberOfSells);



            }
            Int32 totalIncome = (int)Menu.Instance.TotalIncome();
            Int32 totalInvestment = (int)Menu.Instance.TotalProdExpense();
            Int32 totalProfit = totalIncome - totalInvestment;

            totalIncomeLabel.Text = (totalIncome > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalIncome.ToString());
            totalInvestmentLabel.Text = (totalInvestment > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalInvestment.ToString());
            totalProfitLabel.Text = (totalProfit > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalProfit.ToString());

            chart.Visible = false;

            food = Menu.Instance.GetMostSelling(QuanLi.Type.FOOD, food);
            drink = Menu.Instance.GetMostSelling(QuanLi.Type.DRINK, drink);
            topping = Menu.Instance.GetMostSelling(QuanLi.Type.TOPPING, topping);
            special = Menu.Instance.GetMostSelling(QuanLi.Type.SPECIAL, special);

            dropdownTimer.Start();
        }

        private void oneMonthButton_Click(object sender, EventArgs e)
        {
            #region handle data
            DateTime now = DateTime.Now;
            int month = now.Month;
            int year = now.Year;
            int day = now.Day;
            all = new List<Dish>();
            double[] x = new double[day], y = new double[day];
            for (int i = 1; i < day; i++)
            {
                List<Dish> dishInDay = Database.Instance.ReadCSVToList<Dish>(
                    ((i > 9) ? i.ToString() : ("0" + i.ToString())) + "-" + ((month > 9) ? month.ToString() : ("0" + month.ToString())) + "-" + year.ToString());
                Int32 dayProfit = 0;
                if (dishInDay != null)
                {
                    foreach (Dish dish in dishInDay)
                    {
                        dayProfit += (int)(dish.Price - dish.ProdExpense) * dish.NumberOfSells;
                    }
                    all.Concat(dishInDay);
                }
                x[i - 1] = i;
                y[i - 1] = dayProfit;

            }


            chart.Plot.AddScatter(x, y, Color.Red);
            chart.Plot.XAxis.ManualTickSpacing(1);
            chart.Plot.SetAxisLimits(1, DateTime.DaysInMonth(year, month), 0);
            chart.Refresh();
            chart.Visible = true;
            all.ToList();

            #endregion
            Operation();
        }

        private void allTimeButton_Click(object sender, EventArgs e)
        {

        }

        void Operation()
        {
            food = GetMostSelling(all.FindAll(ele => ele.Type == QuanLi.Type.FOOD));
            drink = GetMostSelling(all.FindAll(ele => ele.Type == QuanLi.Type.DRINK));
            topping = GetMostSelling(all.FindAll(ele => ele.Type == QuanLi.Type.TOPPING));
            special = GetMostSelling(all.FindAll(ele => ele.Type == QuanLi.Type.SPECIAL));

            Int32 totalIncome = 0, totalInvestment = 0, totalProfit = 0;
            foreach (Dish dish in all)
            {
                dtgvStatistic.Rows.Add(
                    dish.Name,
                    dish.Type.ToString(),
                    dish.NumberOfSells,
                    dish.Price * dish.NumberOfSells,
                    (dish.Price - dish.ProdExpense) * dish.NumberOfSells);

                totalIncome += (int)dish.Price * dish.NumberOfSells;
                totalInvestment += (int)dish.ProdExpense * dish.NumberOfSells;
            }
            totalProfit = totalIncome - totalInvestment;
            totalIncomeLabel.Text = (totalIncome > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalIncome.ToString());
            totalInvestmentLabel.Text = (totalInvestment > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalInvestment.ToString());
            totalProfitLabel.Text = (totalProfit > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalProfit.ToString());

            DateTime updateTime = DateTime.Now;
            updateTimeLabel.Text = "Cập nhật lần cuối:  " + updateTime.ToString("HH : mm : ss     dd/MM/yyyy");

            dropdownTimer.Start();
        }

        string ConvertToMoneyString(string money)
        {
            for (int i = money.Length - 4; i >= 0; i -= 3)
            {
                money.Insert(i + 1, " ");
            }
            return money;
        }

        List<Dish> GetMostSelling(List<Dish> dishes)
        {
            dishes.Sort((a, b) => (a > b) ? -1 : 0);
            List<Dish> tempDish = new List<Dish>();
            int mostSelling = 0;
            foreach (Dish dish in dishes)
            {
                if (dish.NumberOfSells >= mostSelling)
                {
                    tempDish.Add(dish);
                    mostSelling = dish.NumberOfSells;
                }
                else
                    break;
            }

            return tempDish;
        }

        
    }
}
