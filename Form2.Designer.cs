
namespace QuanLi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            btnBestSellingTopping = new System.Windows.Forms.Button();
            btnBestSellingDrink = new System.Windows.Forms.Button();
            plStatistic = new System.Windows.Forms.Panel();
            plTotalProfit = new System.Windows.Forms.Panel();
            tbxTotalProfit = new System.Windows.Forms.TextBox();
            lbTotalProfit = new System.Windows.Forms.Label();
            plTotalInvestment = new System.Windows.Forms.Panel();
            tbxTotalInvestment = new System.Windows.Forms.TextBox();
            lbTotalInvestment = new System.Windows.Forms.Label();
            plTotalIncome = new System.Windows.Forms.Panel();
            tbxTotalIncome = new System.Windows.Forms.TextBox();
            lbTotalIncome = new System.Windows.Forms.Label();
            btnBestSellingFood = new System.Windows.Forms.Button();
            plProfitChart = new System.Windows.Forms.Panel();
            panel15 = new System.Windows.Forms.Panel();
            dtgvBSFood = new System.Windows.Forms.DataGridView();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Dish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            plStatistic.SuspendLayout();
            plTotalProfit.SuspendLayout();
            plTotalInvestment.SuspendLayout();
            plTotalIncome.SuspendLayout();
            plProfitChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBSFood).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBestSellingTopping);
            panel1.Controls.Add(btnBestSellingDrink);
            panel1.Controls.Add(plStatistic);
            panel1.Controls.Add(btnBestSellingFood);
            panel1.Controls.Add(plProfitChart);
            panel1.Location = new System.Drawing.Point(7, 8);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1581, 774);
            panel1.TabIndex = 0;
            // 
            // btnBestSellingTopping
            // 
            btnBestSellingTopping.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingTopping.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingTopping.BackgroundImage");
            btnBestSellingTopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBestSellingTopping.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingTopping.Location = new System.Drawing.Point(591, 688);
            btnBestSellingTopping.Name = "btnBestSellingTopping";
            btnBestSellingTopping.Size = new System.Drawing.Size(213, 66);
            btnBestSellingTopping.TabIndex = 3;
            btnBestSellingTopping.Text = "           BestSelling\r\n           Topping";
            btnBestSellingTopping.UseVisualStyleBackColor = false;
            btnBestSellingTopping.Click += btnBestSellingTopping_Click;
            // 
            // btnBestSellingDrink
            // 
            btnBestSellingDrink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnBestSellingDrink.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingDrink.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingDrink.BackgroundImage");
            btnBestSellingDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBestSellingDrink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBestSellingDrink.Location = new System.Drawing.Point(311, 688);
            btnBestSellingDrink.Name = "btnBestSellingDrink";
            btnBestSellingDrink.Size = new System.Drawing.Size(213, 66);
            btnBestSellingDrink.TabIndex = 2;
            btnBestSellingDrink.Text = "           BestSelling\r\n           Drink\r\n";
            btnBestSellingDrink.UseVisualStyleBackColor = false;
            btnBestSellingDrink.Click += btnBestSellingDrink_Click;
            // 
            // plStatistic
            // 
            plStatistic.BackColor = System.Drawing.Color.GreenYellow;
            plStatistic.Controls.Add(dtgvBSFood);
            plStatistic.Controls.Add(plTotalProfit);
            plStatistic.Controls.Add(plTotalInvestment);
            plStatistic.Controls.Add(plTotalIncome);
            plStatistic.Location = new System.Drawing.Point(851, 8);
            plStatistic.Name = "plStatistic";
            plStatistic.Size = new System.Drawing.Size(727, 746);
            plStatistic.TabIndex = 2;
            // 
            // plTotalProfit
            // 
            plTotalProfit.Controls.Add(tbxTotalProfit);
            plTotalProfit.Controls.Add(lbTotalProfit);
            plTotalProfit.Location = new System.Drawing.Point(17, 680);
            plTotalProfit.Name = "plTotalProfit";
            plTotalProfit.Size = new System.Drawing.Size(627, 44);
            plTotalProfit.TabIndex = 2;
            // 
            // tbxTotalProfit
            // 
            tbxTotalProfit.Location = new System.Drawing.Point(192, 6);
            tbxTotalProfit.Name = "tbxTotalProfit";
            tbxTotalProfit.ReadOnly = true;
            tbxTotalProfit.Size = new System.Drawing.Size(368, 31);
            tbxTotalProfit.TabIndex = 7;
            // 
            // lbTotalProfit
            // 
            lbTotalProfit.AutoSize = true;
            lbTotalProfit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalProfit.Location = new System.Drawing.Point(3, 9);
            lbTotalProfit.Name = "lbTotalProfit";
            lbTotalProfit.Size = new System.Drawing.Size(86, 25);
            lbTotalProfit.TabIndex = 0;
            lbTotalProfit.Text = "Tổng lãi:";
            // 
            // plTotalInvestment
            // 
            plTotalInvestment.Controls.Add(tbxTotalInvestment);
            plTotalInvestment.Controls.Add(lbTotalInvestment);
            plTotalInvestment.Location = new System.Drawing.Point(17, 630);
            plTotalInvestment.Name = "plTotalInvestment";
            plTotalInvestment.Size = new System.Drawing.Size(627, 44);
            plTotalInvestment.TabIndex = 1;
            // 
            // tbxTotalInvestment
            // 
            tbxTotalInvestment.Location = new System.Drawing.Point(192, 6);
            tbxTotalInvestment.Name = "tbxTotalInvestment";
            tbxTotalInvestment.ReadOnly = true;
            tbxTotalInvestment.Size = new System.Drawing.Size(368, 31);
            tbxTotalInvestment.TabIndex = 6;
            // 
            // lbTotalInvestment
            // 
            lbTotalInvestment.AutoSize = true;
            lbTotalInvestment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalInvestment.Location = new System.Drawing.Point(3, 9);
            lbTotalInvestment.Name = "lbTotalInvestment";
            lbTotalInvestment.Size = new System.Drawing.Size(98, 25);
            lbTotalInvestment.TabIndex = 0;
            lbTotalInvestment.Text = "Tổng vốn:";
            // 
            // plTotalIncome
            // 
            plTotalIncome.Controls.Add(tbxTotalIncome);
            plTotalIncome.Controls.Add(lbTotalIncome);
            plTotalIncome.Location = new System.Drawing.Point(17, 580);
            plTotalIncome.Name = "plTotalIncome";
            plTotalIncome.Size = new System.Drawing.Size(627, 44);
            plTotalIncome.TabIndex = 0;
            // 
            // tbxTotalIncome
            // 
            tbxTotalIncome.Location = new System.Drawing.Point(192, 6);
            tbxTotalIncome.Name = "tbxTotalIncome";
            tbxTotalIncome.ReadOnly = true;
            tbxTotalIncome.Size = new System.Drawing.Size(368, 31);
            tbxTotalIncome.TabIndex = 5;
            // 
            // lbTotalIncome
            // 
            lbTotalIncome.AutoSize = true;
            lbTotalIncome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalIncome.Location = new System.Drawing.Point(3, 9);
            lbTotalIncome.Name = "lbTotalIncome";
            lbTotalIncome.Size = new System.Drawing.Size(154, 25);
            lbTotalIncome.TabIndex = 0;
            lbTotalIncome.Text = "Tổng thành tiền:";
            // 
            // btnBestSellingFood
            // 
            btnBestSellingFood.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingFood.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingFood.BackgroundImage");
            btnBestSellingFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBestSellingFood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingFood.Location = new System.Drawing.Point(38, 688);
            btnBestSellingFood.Name = "btnBestSellingFood";
            btnBestSellingFood.Size = new System.Drawing.Size(213, 66);
            btnBestSellingFood.TabIndex = 1;
            btnBestSellingFood.Text = "           BestSelling\r\n           Food";
            btnBestSellingFood.UseVisualStyleBackColor = false;
            btnBestSellingFood.Click += btnBestSellingFood_Click;
            // 
            // plProfitChart
            // 
            plProfitChart.BackColor = System.Drawing.Color.IndianRed;
            plProfitChart.Controls.Add(panel15);
            plProfitChart.Location = new System.Drawing.Point(9, 8);
            plProfitChart.Name = "plProfitChart";
            plProfitChart.Size = new System.Drawing.Size(824, 664);
            plProfitChart.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.Color.LightCoral;
            panel15.Location = new System.Drawing.Point(18, 16);
            panel15.Name = "panel15";
            panel15.Size = new System.Drawing.Size(790, 626);
            panel15.TabIndex = 0;
            // 
            // dtgvBSFood
            // 
            dtgvBSFood.AllowUserToOrderColumns = true;
            dtgvBSFood.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dtgvBSFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dtgvBSFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgvBSFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvBSFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBSFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Date, Dish, Type, Sell, Price, Profit });
            dtgvBSFood.EnableHeadersVisualStyles = false;
            dtgvBSFood.Location = new System.Drawing.Point(17, 16);
            dtgvBSFood.Name = "dtgvBSFood";
            dtgvBSFood.RowHeadersWidth = 62;
            dtgvBSFood.RowTemplate.Height = 33;
            dtgvBSFood.Size = new System.Drawing.Size(695, 545);
            dtgvBSFood.TabIndex = 8;
            // 
            // Date
            // 
            Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Date.HeaderText = "Ngày";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            // 
            // Dish
            // 
            Dish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Dish.HeaderText = "Món";
            Dish.MinimumWidth = 8;
            Dish.Name = "Dish";
            // 
            // Type
            // 
            Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Loại";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            // 
            // Sell
            // 
            Sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sell.HeaderText = "Số lượng";
            Sell.MinimumWidth = 8;
            Sell.Name = "Sell";
            // 
            // Price
            // 
            Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            // 
            // Profit
            // 
            Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Profit.HeaderText = "Lợi nhuận";
            Profit.MinimumWidth = 8;
            Profit.Name = "Profit";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1600, 794);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Doanh thu";
            panel1.ResumeLayout(false);
            plStatistic.ResumeLayout(false);
            plTotalProfit.ResumeLayout(false);
            plTotalProfit.PerformLayout();
            plTotalInvestment.ResumeLayout(false);
            plTotalInvestment.PerformLayout();
            plTotalIncome.ResumeLayout(false);
            plTotalIncome.PerformLayout();
            plProfitChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBSFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plStatistic;
        private System.Windows.Forms.Panel plTotalProfit;
        private System.Windows.Forms.TextBox tbxTotalProfit;
        private System.Windows.Forms.Label lbTotalProfit;
        private System.Windows.Forms.Panel plTotalInvestment;
        private System.Windows.Forms.TextBox tbxTotalInvestment;
        private System.Windows.Forms.Label lbTotalInvestment;
        private System.Windows.Forms.Panel plTotalIncome;
        private System.Windows.Forms.TextBox tbxTotalIncome;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.Panel plProfitChart;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnBestSellingFood;
        private System.Windows.Forms.Button btnBestSellingTopping;
        private System.Windows.Forms.Button btnBestSellingDrink;
        private System.Windows.Forms.DataGridView dtgvBSFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}