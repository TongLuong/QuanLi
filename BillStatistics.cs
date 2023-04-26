using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class BillStatistics : Form
    {
        public BillStatistics()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            List<Bill> bills = ListBill.Instance.Bills;
            if (bills.Count == 0) return;

            Bill maxBill = null;

            Int32 totalPrice = 0;

            foreach (Bill bill in bills)
            {
                if (maxBill == null)
                {
                    maxBill = bill;
                }
                else if (bill.Total > maxBill.Total)
                {
                    maxBill = bill;
                }
                dtgvBills.Rows.Add(bill.ID, bill.Total);

                totalPrice += (int)bill.Total;
            }

            numberOfBills.Text = "Tổng số hoá đơn : " + bills.Count.ToString();

            mostValueBillID.Text = "Mã hoá đơn : " + maxBill.ID.ToString();
            mostValueBillPrice.Text = "Doanh thu : " + maxBill.Total.ToString();

            averagePrice.Text = "Doanh thu trung bình : " + (totalPrice / bills.Count).ToString();
        }

        private void BillStatistics_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
        }
    }
}
