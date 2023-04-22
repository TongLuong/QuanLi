using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QuanLi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ChartInitialize();
        }

        #region feature
        List<Dish> all = new List<Dish>();
        List<Dish> food = new List<Dish>();
        List<Dish> drink = new List<Dish>();
        List<Dish> topping = new List<Dish>();
        #endregion

        private void btnBestSellingDrink_Click(object sender, EventArgs e)
        {
            fBSDrink f = new fBSDrink();
            f.ShowDialog();
        }

        private void btnBestSellingFood_Click(object sender, EventArgs e)
        {
            fBSFood f = new fBSFood();
            f.ShowDialog();
        }

        private void btnBestSellingTopping_Click(object sender, EventArgs e)
        {
            fBSTopping f = new fBSTopping();
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

        }

        private void oneMonthButton_Click(object sender, EventArgs e)
        {

        }

        private void allTimeButton_Click(object sender, EventArgs e)
        {

        }

        void Operation()
        {
            if (all.Count <= 1)
                chart.Visible = false;
            else
            {

                //chart.Plot.AddScatter()
                chart.Visible = true;
            }
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
                totalInvestment += (int)dish.ProdExpense;
                totalProfit = (int)(dish.Price - dish.ProdExpense) * dish.NumberOfSells;

            }
            totalIncomeLabel.Text = (totalIncome > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalIncome.ToString());
            totalInvestmentLabel.Text = (totalInvestment > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalInvestment.ToString());
            totalProfitLabel.Text = (totalProfit > Int32.MaxValue) ? "Số tiền quá lớn" : ConvertToMoneyString(totalProfit.ToString());
        
            DateTime updateTime = DateTime.Now;
            updateTimeLabel.Text = "Cập nhật lần cuối:  " + updateTime.ToString("HH : mm : ss dd/MM/yyyy");
        }

        string ConvertToMoneyString(string money)
        {
            for (int i = money.Length - 4; i >= 0; i -= 3)
            {
                money.Insert(i + 1, " ");
            }
            return money;
        }

    }
}
