using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using System.Globalization;
using ScottPlot;

namespace QuanLi
{
    public partial class FormStatistics : Form
    {
        #region lists
        List<Dish> all = null;
        List<Dish> food = new List<Dish>();
        List<Dish> drink = new List<Dish>();
        List<Dish> topping = new List<Dish>();
        List<Dish> special = new List<Dish>();

        List<KeyValuePair<int, string>> indexInDtgv = new List<KeyValuePair<int, string>>();
        #endregion

        #region best selling forms
        fBS foodForm = null;
        fBS drinkForm = null;
        fBS toppingForm = null;
        fBS specialForm = null;
        #endregion

        public FormStatistics()
        {
            InitializeComponent();
            FormInit();
        }


        private void btnBestSellingDrink_Click(object sender, EventArgs e)
        {
            drinkForm = new fBS();
            drinkForm.LoadData(drink, "Đồ uống");
            drinkForm.ShowDialog();
        }

        private void btnBestSellingFood_Click(object sender, EventArgs e)
        {
            foodForm = new fBS();
            foodForm.LoadData(food, "Món ăn");
            foodForm.ShowDialog();

        }

        private void btnBestSellingTopping_Click(object sender, EventArgs e)
        {
            toppingForm = new fBS();
            toppingForm.LoadData(topping, "Topping");
            toppingForm.ShowDialog();
        }

        private void btnBestSellingSpecial_Click(object sender, EventArgs e)
        {
            specialForm = new fBS();
            specialForm.LoadData(special, "Món đặc biệt");
            specialForm.ShowDialog();
        }

        private void dropdownButton_Click(object sender, EventArgs e)
        {
            dropdownTimer.Start();
            //HandleDropdown();
        }
        bool listOpened = false;
        private void dropdownTimer_Tick(object sender, EventArgs e)
        {
            dropdownPanel.Enabled = false;
            if (listOpened)
            {
                dropdownPanel.Height -= 20;
                if (dropdownPanel.Size == dropdownPanel.MinimumSize)
                {
                    dropdownTimer.Stop();
                    dropdownPanel.Enabled = true;
                    listOpened = false;
                }
            }
            else
            {
                dropdownPanel.Height += 20;
                if (dropdownPanel.Size == dropdownPanel.MaximumSize)
                {
                    dropdownTimer.Stop();
                    dropdownPanel.Enabled = true;
                    listOpened = true;
                }
            }
        }

        void FormInit()
        {
            all = Menu.Instance.getListByType(QuanLi.Type.FOOD).Concat(Menu.Instance.getListByType(QuanLi.Type.DRINK)).Concat(Menu.Instance.getListByType(QuanLi.Type.TOPPING)).Concat(Menu.Instance.getListByType(QuanLi.Type.SPECIAL)).ToList();
            int index = 0;
            foreach (Dish dish in all)
            {
                dtgvStatistic.Rows.Add(dish.Name, dish.Type.ToString(), (Int64)0, (Int64)0, (Int64)0);
                indexInDtgv.Add(new KeyValuePair<int, string>(index++, dish.Name));
            }

            foreach (Dish dish in all)
            {
                foreach (KeyValuePair<int, string> idx in indexInDtgv)
                {
                    if (dish.Name == idx.Value)
                    {
                        DataGridViewRow row = dtgvStatistic.Rows[idx.Key];
                        row.Cells[2].Value = (Int64)row.Cells[2].Value + (Int64)dish.NumberOfSells;
                        row.Cells[3].Value = (Int64)row.Cells[3].Value + dish.NumberOfSells * (Int64)dish.Price;
                        row.Cells[4].Value = (Int64)row.Cells[4].Value + dish.NumberOfSells * (Int64)(dish.Price - dish.ProdExpense);
                    }
                }
            }
            Int64 totalIncome = (Int64)Menu.Instance.TotalIncome();
            Int64 totalInvestment = (Int64)Menu.Instance.TotalProdExpense();
            Int64 totalProfit = totalIncome - totalInvestment;

            totalIncomeLabel.Text = (totalIncome > Int64.MaxValue) ? "Số tiền quá lớn" : totalIncome.ToString("#,##0");
            totalInvestmentLabel.Text = (totalInvestment > Int64.MaxValue) ? "Số tiền quá lớn" : totalInvestment.ToString("#,##0");
            totalProfitLabel.Text = (totalProfit > Int64.MaxValue) ? "Số tiền quá lớn" : totalProfit.ToString("#,##0");

            food = Menu.Instance.GetMostSelling(QuanLi.Type.FOOD, food);
            drink = Menu.Instance.GetMostSelling(QuanLi.Type.DRINK, drink);
            topping = Menu.Instance.GetMostSelling(QuanLi.Type.TOPPING, topping);
            special = Menu.Instance.GetMostSelling(QuanLi.Type.SPECIAL, special);

            DateTime updateTime = DateTime.Now;
            updateTimeLabel.Text = "Cập nhật lần cuối:  " + updateTime.ToString("HH : mm : ss     dd/MM/yyyy");

            statisticsTypeLabel.Text = "Thống kê theo hôm nay";
        }


        private void todayButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            all = Menu.Instance.getListByType(QuanLi.Type.FOOD).Concat(Menu.Instance.getListByType(QuanLi.Type.DRINK)).Concat(Menu.Instance.getListByType(QuanLi.Type.TOPPING)).Concat(Menu.Instance.getListByType(QuanLi.Type.SPECIAL)).ToList();

            foreach (Dish dish in all)
            {
                foreach (KeyValuePair<int, string> idx in indexInDtgv)
                {
                    if (dish.Name == idx.Value)
                    {
                        DataGridViewRow row = dtgvStatistic.Rows[idx.Key];
                        row.Cells[2].Value = (Int64)row.Cells[2].Value + (Int64)dish.NumberOfSells;
                        row.Cells[3].Value = (Int64)row.Cells[3].Value + dish.NumberOfSells * (Int64)dish.Price;
                        row.Cells[4].Value = (Int64)row.Cells[4].Value + dish.NumberOfSells * (Int64)(dish.Price - dish.ProdExpense);
                    }
                }
            }
            Int64 totalIncome = (Int64)Menu.Instance.TotalIncome();
            Int64 totalInvestment = (Int64)Menu.Instance.TotalProdExpense();
            Int64 totalProfit = totalIncome - totalInvestment;

            totalIncomeLabel.Text = (totalIncome > Int64.MaxValue) ? "Số tiền quá lớn" : totalIncome.ToString("#,##0");
            totalInvestmentLabel.Text = (totalInvestment > Int64.MaxValue) ? "Số tiền quá lớn" : totalInvestment.ToString("#,##0");
            totalProfitLabel.Text = (totalProfit > Int64.MaxValue) ? "Số tiền quá lớn" : totalProfit.ToString("#,##0");

            allTimeChart.Visible = false;
            oneMonthChart.Visible = false;

            food = Menu.Instance.GetMostSelling(QuanLi.Type.FOOD, food);
            drink = Menu.Instance.GetMostSelling(QuanLi.Type.DRINK, drink);
            topping = Menu.Instance.GetMostSelling(QuanLi.Type.TOPPING, topping);
            special = Menu.Instance.GetMostSelling(QuanLi.Type.SPECIAL, special);

            DateTime updateTime = DateTime.Now;
            updateTimeLabel.Text = "Cập nhật lần cuối:  " + updateTime.ToString("HH : mm : ss     dd/MM/yyyy");

            statisticsTypeLabel.Text = "Thống kê theo hôm nay";

            dropdownTimer.Start();
        }

        private void oneMonthButton_Click(object sender, EventArgs e)
        {
            #region handle data
            DateTime now = DateTime.Now;
            int month = now.Month;
            int year = now.Year;
            int day = now.Day;
            all.Clear();
            List<int> idx = new List<int>();
            List<Int64> profits = new List<Int64>();
            idx.Clear();
            profits.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                List<Dish> dishInDay = Database.Instance.ReadCSVToList<Dish>(
                    ((i > 9) ? i.ToString() : ("0" + i.ToString())) + "-" + ((month > 9) ? month.ToString() : ("0" + month.ToString())) + "-" + year.ToString());
                Int64 dayProfit = 0;
                if (dishInDay != null)
                {
                    all = all.Concat(dishInDay).ToList();

                    foreach (Dish dish in dishInDay)
                    {
                        dayProfit += (Int64)(dish.Price - dish.ProdExpense) * dish.NumberOfSells;
                    }

                    idx.Add(i);
                    profits.Add(dayProfit);
                }
            }

            double[] x = idx.Select(a => (double)a).ToArray();
            double[] y = profits.Select(a => Convert.ToDouble(a)).ToArray();

            oneMonthChart.Plot.Clear();
            oneMonthChart.Plot.AddScatter(x, y, Color.Red);
            oneMonthChart.Plot.XAxis.ManualTickSpacing(1);
            oneMonthChart.Plot.SetAxisLimits(1, DateTime.DaysInMonth(year, month), 0);
            oneMonthChart.Plot.XLabel("Số ngày");
            oneMonthChart.Refresh();
            oneMonthChart.Visible = true;
            allTimeChart.Visible = false;
            all.ToList();

            #endregion
            Operation();

            statisticsTypeLabel.Text = "Thống kê theo tháng " + now.ToString("MM - yyyy");

        }

        private void allTimeButton_Click(object sender, EventArgs e)
        {
            all = Database.Instance.ReadCSVAllDate<Dish>();
            all.Sort();
            int month = 0, year = 0;
            List<Int64> profits = new List<Int64>();
            profits.Clear();
            List<string> dates = new List<string>();
            dates.Clear();
            Int64 monthProfit = 0;
            for (int i = 0; i < all.Count; i++)
            {
                Dish dish = all[i];
                #region convert to date time
                DateTime dt;
                if (DateTime.TryParseExact(dish.Time, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                {

                    if (dt.Month == month && dt.Year == year)
                    {
                        monthProfit += dish.NumberOfSells * (Int64)(dish.Price - dish.ProdExpense);
                    }
                    else
                    {
                        if (month != 0 && year != 0)
                        {
                            profits.Add(monthProfit);

                            //Int32 timeDistance = (dt.Year - year) * 12 + dt.Month - month - 1;
                            //int tempMonth = month + 1, tempYear = year;
                            //while (timeDistance-->0)
                            //{
                            //    if (tempMonth > 12)
                            //    {
                            //        tempMonth = 1;
                            //        tempYear++;
                            //    }    
                            //    profits.Add(0);
                            //    dates.Add(new DateTime(tempYear, tempMonth++, 1).ToString("MM - yyyy"));
                            //}
                        }

                        monthProfit = dish.NumberOfSells * (Int64)(dish.Price - dish.ProdExpense);
                        month = dt.Month;
                        year = dt.Year;

                        dates.Add(new DateTime(year, month, 1).ToString("MM - yyyy"));
                    }
                    if (i == all.Count - 1)
                    {
                        profits.Add(monthProfit);
                        break;
                    }
                }
                #endregion

            }
            if (profits.Count > 1)
            {
                #region convert to double[] and draw chart
                double[] x = new double[profits.Count];
                double[] y = profits.Select(x => Convert.ToDouble(x)).ToArray();

                for (int i = 0; i < profits.Count; i++)
                {
                    x[i] = i + 1;
                }
                allTimeChart.Plot.Clear();
                allTimeChart.Plot.AddScatter(x, y, Color.Red);
                allTimeChart.Plot.XAxis.ManualTickPositions(x, dates.ToArray());
                allTimeChart.Plot.SetAxisLimits(1, profits.Count, 0);
                allTimeChart.Plot.XLabel("Số tháng");
                allTimeChart.Refresh();
                allTimeChart.Visible = true;
                oneMonthChart.Visible = false;
                #endregion
            }
            else
                allTimeChart.Visible = false;

            Operation();

            statisticsTypeLabel.Text = "Thống kê theo toàn thời gian";
        }

        void Operation()
        {
            RefreshDataGridView();

            Int64 totalIncome = 0, totalInvestment = 0, totalProfit;
            foreach (Dish dish in all)
            {
                foreach (KeyValuePair<int, string> idx in indexInDtgv)
                {
                    if (dish.Name == idx.Value)
                    {
                        DataGridViewRow row = dtgvStatistic.Rows[idx.Key];
                        row.Cells[2].Value = (Int64)row.Cells[2].Value + (Int64)dish.NumberOfSells;
                        row.Cells[3].Value = (Int64)row.Cells[3].Value + dish.NumberOfSells * (Int64)dish.Price;
                        row.Cells[4].Value = (Int64)row.Cells[4].Value + dish.NumberOfSells * (Int64)(dish.Price - dish.ProdExpense);
                    }
                }

                totalIncome += (Int64)dish.Price * dish.NumberOfSells;
                totalInvestment += (Int64)dish.ProdExpense * dish.NumberOfSells;
            }
            totalProfit = totalIncome - totalInvestment;
            totalIncomeLabel.Text = (totalIncome > Int64.MaxValue) ? "Số tiền quá lớn" : totalIncome.ToString("#,##0");
            totalInvestmentLabel.Text = (totalInvestment > Int64.MaxValue) ? "Số tiền quá lớn" : totalInvestment.ToString("#,##0");
            totalProfitLabel.Text = (totalProfit > Int64.MaxValue) ? "Số tiền quá lớn" : totalProfit.ToString("#,##0");

            food.Clear();
            drink.Clear();
            topping.Clear();
            special.Clear();

            food = GetMostSelling(QuanLi.Type.FOOD);
            drink = GetMostSelling(QuanLi.Type.DRINK);
            topping = GetMostSelling(QuanLi.Type.TOPPING);
            special = GetMostSelling(QuanLi.Type.SPECIAL);

            DateTime updateTime = DateTime.Now;
            updateTimeLabel.Text = "Cập nhật lần cuối:  " + updateTime.ToString("HH : mm : ss     dd/MM/yyyy");

            dropdownTimer.Start();
        }


        List<Dish> GetMostSelling(Type type)
        {
            List<Dish> dishes = Menu.Instance.getListByType(type);
            List<Dish> mostSellingDishes = new List<Dish>();
            mostSellingDishes.Clear();
            Int64 maxProfit = 0;
            foreach (Dish dish in dishes)
            {
                foreach (KeyValuePair<int, string> idx in indexInDtgv)
                {
                    if (dish.Name == idx.Value)
                    {
                        Int64 profit = (Int64)dtgvStatistic.Rows[idx.Key].Cells[4].Value;

                        Dish tempDish = new Dish(
                            dish.ID,
                            dish.Name,
                            dish.Price,
                            dish.ProdExpense,
                            (Int32)(Int64)dtgvStatistic.Rows[idx.Key].Cells[2].Value,
                            dish.Type,
                            dish.ImageName);

                        if (profit > maxProfit)
                        {
                            mostSellingDishes.Clear();
                            mostSellingDishes.Add(tempDish);
                            maxProfit = profit;
                            continue;
                        }
                        if (profit == maxProfit)
                            mostSellingDishes.Add(tempDish);
                        break;
                    }
                }
            }

            return mostSellingDishes;
        }

        void RefreshDataGridView()
        {
            for (int i = 0; i < indexInDtgv.Count; i++)
            {
                DataGridViewRow row = dtgvStatistic.Rows[i];
                row.Cells[2].Value = (Int64)0;
                row.Cells[3].Value = (Int64)0;
                row.Cells[4].Value = (Int64)0;
            }
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            BillStatistics billForm = new BillStatistics();
            billForm.ShowDialog();
        }
    }
}
