﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;
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
        fBSFood foodForm = null;
        fBSDrink drinkForm = null;
        fBSTopping toppingForm = null;
        fBSSpecial specialForm = null;
        #endregion

        public FormStatistics()
        {
            InitializeComponent();
            ChartInitialize();
            FormInit();
        }


        private void btnBestSellingDrink_Click(object sender, EventArgs e)
        {
            drinkForm = new fBSDrink();
            drinkForm.LoadData(drink);
            drinkForm.ShowDialog();
        }

        private void btnBestSellingFood_Click(object sender, EventArgs e)
        {
            foodForm = new fBSFood();
            foodForm.LoadData(food);
            foodForm.ShowDialog();

        }

        private void btnBestSellingTopping_Click(object sender, EventArgs e)
        {
            toppingForm = new fBSTopping();
            toppingForm.LoadData(topping);
            toppingForm.ShowDialog();
        }

        private void btnBestSellingSpecial_Click(object sender, EventArgs e)
        {
            specialForm = new fBSSpecial();
            specialForm.LoadData(special);
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
                dtgvStatistic.Rows.Add(dish.Name, dish.Type.ToString(), 0, 0, 0);
                indexInDtgv.Add(new KeyValuePair<int, string>(index++, dish.Name));
            }

            foreach (Dish dish in all)
            {
                foreach (KeyValuePair<int, string> idx in indexInDtgv)
                {
                    if (dish.Name == idx.Value)
                    {
                        DataGridViewRow row = dtgvStatistic.Rows[idx.Key];
                        row.Cells[2].Value = (int)row.Cells[2].Value + dish.NumberOfSells;
                        row.Cells[3].Value = (int)row.Cells[3].Value + dish.NumberOfSells * (int)dish.Price;
                        row.Cells[4].Value = (int)row.Cells[4].Value + dish.NumberOfSells * (int)(dish.Price - dish.ProdExpense);
                    }
                }
            }
            Int32 totalIncome = (Int32)Menu.Instance.TotalIncome();
            Int32 totalInvestment = (Int32)Menu.Instance.TotalProdExpense();
            Int32 totalProfit = totalIncome - totalInvestment;

            totalIncomeLabel.Text = (totalIncome > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalIncome.ToString());
            totalInvestmentLabel.Text = (totalInvestment > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalInvestment.ToString());
            totalProfitLabel.Text = (totalProfit > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalProfit.ToString());

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
                        row.Cells[2].Value = (Int32)row.Cells[2].Value + dish.NumberOfSells;
                        row.Cells[3].Value = (Int32)row.Cells[3].Value + dish.NumberOfSells * (Int32)dish.Price;
                        row.Cells[4].Value = (Int32)row.Cells[4].Value + dish.NumberOfSells * (Int32)(dish.Price - dish.ProdExpense);
                    }
                }

            }
            Int32 totalIncome = (Int32)Menu.Instance.TotalIncome();
            Int32 totalInvestment = (Int32)Menu.Instance.TotalProdExpense();
            Int32 totalProfit = totalIncome - totalInvestment;

            totalIncomeLabel.Text = (totalIncome > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalIncome.ToString());
            totalInvestmentLabel.Text = (totalInvestment > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalInvestment.ToString());
            totalProfitLabel.Text = (totalProfit > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalProfit.ToString());

            chart.Visible = false;

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
            double[] x = new double[day - 1], y = new double[day - 1];
            for (int i = 1; i < day; i++)
            {
                List<Dish> dishInDay = Database.Instance.ReadCSVToList<Dish>(
                    ((i > 9) ? i.ToString() : ("0" + i.ToString())) + "-" + ((month > 9) ? month.ToString() : ("0" + month.ToString())) + "-" + year.ToString());
                Int32 dayProfit = 0;
                if (dishInDay != null)
                {

                    all = all.Concat(dishInDay).ToList();

                    foreach (Dish dish in dishInDay)
                    {
                        dayProfit += (Int32)(dish.Price - dish.ProdExpense) * dish.NumberOfSells;
                    }
                }
                x[i - 1] = i;
                y[i - 1] = dayProfit;

            }

            chart.Plot.Clear();
            chart.Plot.AddScatter(x, y, Color.Red);
            chart.Plot.XAxis.ManualTickSpacing(1);
            chart.Plot.SetAxisLimits(1, DateTime.DaysInMonth(year, month), 0);
            chart.Plot.XLabel("Số ngày");
            chart.Refresh();
            chart.Visible = true;
            all.ToList();

            #endregion
            Operation();

            statisticsTypeLabel.Text = "Thống kê theo tháng hiện tại";

        }

        private void allTimeButton_Click(object sender, EventArgs e)
        {
            all = Database.Instance.ReadCSVAllDate<Dish>();
            int month = 0, year = 0;
            List<Int32> profits = null;
            Int32 monthProfit = 0;
            foreach (Dish dish in all)
            {

                #region convert to date time
                DateTime dt;
                if (DateTime.TryParseExact(dish.Time, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                {
                    if (dt.Month == month && dt.Year == year)
                    {
                        monthProfit += dish.NumberOfSells * (Int32)(dish.Price - dish.ProdExpense);
                    }
                    else
                    {
                        if ((month != 0 && year != 0) || dish == all[all.Count - 1])
                        {
                            if (profits == null)
                                profits = new List<Int32>(monthProfit);
                            else
                                profits.Add(monthProfit);
                        }
                        monthProfit = dish.NumberOfSells * (Int32)(dish.Price - dish.ProdExpense);
                        month = dt.Month;
                        year = dt.Year;
                    }
                }
                #endregion

            }
            if (profits.Count > 1)
            {
                #region convert to double[] and draw chart
                double[] x = new double[profits.Count];
                double[] y = new double[profits.Count];

                for (int i = 0; i < profits.Count; i++)
                {
                    x[i] = i + 1;
                    y[i] = profits[i];
                }
                chart.Plot.Clear();
                chart.Plot.AddScatter(x, y, Color.Red);
                chart.Plot.XAxis.ManualTickSpacing(1);
                chart.Plot.SetAxisLimits(1, profits.Count, 0);
                chart.Plot.XLabel("Số tháng");
                chart.Refresh();
                chart.Visible = true;
                #endregion
            }
            else
                chart.Visible = false;

            Operation();

            statisticsTypeLabel.Text = "Thống kê theo toàn thời gian";
        }

        void Operation()
        {
            RefreshDataGridView();

            Int32 totalIncome = 0, totalInvestment = 0, totalProfit;
            foreach (Dish dish in all)
            {
                foreach (KeyValuePair<int, string> idx in indexInDtgv)
                {
                    if (dish.Name == idx.Value)
                    {
                        DataGridViewRow row = dtgvStatistic.Rows[idx.Key];
                        row.Cells[2].Value = (Int32)row.Cells[2].Value + dish.NumberOfSells;
                        row.Cells[3].Value = (Int32)row.Cells[3].Value + dish.NumberOfSells * (Int32)dish.Price;
                        row.Cells[4].Value = (Int32)row.Cells[4].Value + dish.NumberOfSells * (Int32)(dish.Price - dish.ProdExpense);
                    }
                }

                totalIncome += (Int32)dish.Price * dish.NumberOfSells;
                totalInvestment += (Int32)dish.ProdExpense * dish.NumberOfSells;
            }
            totalProfit = totalIncome - totalInvestment;
            totalIncomeLabel.Text = (totalIncome > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalIncome.ToString());
            totalInvestmentLabel.Text = (totalInvestment > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalInvestment.ToString());
            totalProfitLabel.Text = (totalProfit > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalProfit.ToString());

            food.Clear();
            drink.Clear();
            topping.Clear();
            special.Clear();

            food = GetMostSelling(QuanLi.Type.FOOD);
            drink = GetMostSelling(QuanLi.Type.DRINK);
            topping = GetMostSelling(QuanLi.Type.TOPPING);
            special = GetMostSelling(QuanLi.Type.SPECIAL);

            foreach (Dish dish in food)
            {
                Debug.Print(dish.Name + " " + dish.NumberOfSells.ToString());
            }

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

        List<Dish> GetMostSelling(Type type)
        {
            List<Dish> dishes = Menu.Instance.getListByType(type);
            List<Dish> mostSellingDishes = new List<Dish>();
            mostSellingDishes.Clear();
            Int32 maxProfit = 0;
            foreach (Dish dish in dishes)
            {
                foreach (KeyValuePair<int, string> idx in indexInDtgv)
                {
                    if (dish.Name == idx.Value)
                    {
                        Int32 profit = (Int32)dtgvStatistic.Rows[idx.Key].Cells[4].Value;

                        Dish tempDish = new Dish(
                            dish.ID,
                            dish.Name,
                            dish.Price,
                            dish.ProdExpense,
                            (int)dtgvStatistic.Rows[idx.Key].Cells[2].Value,
                            dish.Type,
                            dish.ImageName);

                        Debug.Print(profit.ToString());
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
                row.Cells[2].Value = 0;
                row.Cells[3].Value = 0;
                row.Cells[4].Value = 0;
            }
        }

        void ChartInitialize()
        {
            chart.Plot.Style(Style.Seaborn);
            chart.Plot.Palette = ScottPlot.Palette.Amber;
            chart.Plot.YLabel("Doanh thu");
            chart.Visible = false;
            chart.Plot.Clear();
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            BillStatistics billForm = new BillStatistics();
            billForm.ShowDialog();
        }
    }
}