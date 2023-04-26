
using ScottPlot;
using System;
using System.Windows.Forms;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelFull = new Panel();
            statisticsTypeLabel = new Label();
            updateTimeLabel = new Label();
            bestSellingPanel = new Panel();
            btnBestSellingSpecial = new Button();
            label1 = new Label();
            btnBestSellingTopping = new Button();
            btnBestSellingDrink = new Button();
            btnBestSellingFood = new Button();
            plStatistic = new Panel();
            billBtn = new Button();
            dtgvStatistic = new DataGridView();
            Dish = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Sell = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            plTotalProfit = new Panel();
            totalProfitLabel = new Label();
            lbTotalProfit = new Label();
            plTotalInvestment = new Panel();
            totalInvestmentLabel = new Label();
            lbTotalInvestment = new Label();
            plTotalIncome = new Panel();
            totalIncomeLabel = new Label();
            lbTotalIncome = new Label();
            plProfitChart = new Panel();
            chart = new FormsPlot();
            dropdownPanel = new Panel();
            allTimeButton = new Button();
            oneMonthButton = new Button();
            todayButton = new Button();
            dropdownButton = new Button();
            dropdownTimer = new Timer(components);
            panelFull.SuspendLayout();
            bestSellingPanel.SuspendLayout();
            plStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStatistic).BeginInit();
            plTotalProfit.SuspendLayout();
            plTotalInvestment.SuspendLayout();
            plTotalIncome.SuspendLayout();
            plProfitChart.SuspendLayout();
            dropdownPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelFull
            // 
            panelFull.Controls.Add(statisticsTypeLabel);
            panelFull.Controls.Add(updateTimeLabel);
            panelFull.Controls.Add(bestSellingPanel);
            panelFull.Controls.Add(plStatistic);
            panelFull.Controls.Add(plProfitChart);
            panelFull.Location = new System.Drawing.Point(8, 8);
            panelFull.Margin = new Padding(2);
            panelFull.Name = "panelFull";
            panelFull.Size = new System.Drawing.Size(1581, 774);
            panelFull.TabIndex = 0;
            // 
            // statisticsTypeLabel
            // 
            statisticsTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            statisticsTypeLabel.Location = new System.Drawing.Point(844, 0);
            statisticsTypeLabel.Margin = new Padding(4, 0, 4, 0);
            statisticsTypeLabel.Name = "statisticsTypeLabel";
            statisticsTypeLabel.Size = new System.Drawing.Size(418, 62);
            statisticsTypeLabel.TabIndex = 6;
            statisticsTypeLabel.Text = "Thống kê trong hôm nay";
            statisticsTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            updateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            updateTimeLabel.Location = new System.Drawing.Point(0, 0);
            updateTimeLabel.Margin = new Padding(4, 0, 4, 0);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(504, 62);
            updateTimeLabel.TabIndex = 5;
            updateTimeLabel.Text = "Cập nhật lần cuối:  00 : 00 : 00 00/00/0000";
            updateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestSellingPanel
            // 
            bestSellingPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            bestSellingPanel.Controls.Add(btnBestSellingSpecial);
            bestSellingPanel.Controls.Add(label1);
            bestSellingPanel.Controls.Add(btnBestSellingTopping);
            bestSellingPanel.Controls.Add(btnBestSellingDrink);
            bestSellingPanel.Controls.Add(btnBestSellingFood);
            bestSellingPanel.Location = new System.Drawing.Point(0, 595);
            bestSellingPanel.Margin = new Padding(4);
            bestSellingPanel.Name = "bestSellingPanel";
            bestSellingPanel.Size = new System.Drawing.Size(844, 179);
            bestSellingPanel.TabIndex = 4;
            // 
            // btnBestSellingSpecial
            // 
            btnBestSellingSpecial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBestSellingSpecial.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingSpecial.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingSpecial.BackgroundImage");
            btnBestSellingSpecial.BackgroundImageLayout = ImageLayout.Zoom;
            btnBestSellingSpecial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingSpecial.Location = new System.Drawing.Point(491, 106);
            btnBestSellingSpecial.Margin = new Padding(2);
            btnBestSellingSpecial.Name = "btnBestSellingSpecial";
            btnBestSellingSpecial.Padding = new Padding(50, 0, 0, 0);
            btnBestSellingSpecial.Size = new System.Drawing.Size(212, 66);
            btnBestSellingSpecial.TabIndex = 6;
            btnBestSellingSpecial.Text = "Special";
            btnBestSellingSpecial.UseVisualStyleBackColor = false;
            btnBestSellingSpecial.Click += btnBestSellingSpecial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(359, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 30);
            label1.TabIndex = 5;
            label1.Text = "Best Selling";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBestSellingTopping
            // 
            btnBestSellingTopping.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBestSellingTopping.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingTopping.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingTopping.BackgroundImage");
            btnBestSellingTopping.BackgroundImageLayout = ImageLayout.Zoom;
            btnBestSellingTopping.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingTopping.Location = new System.Drawing.Point(126, 106);
            btnBestSellingTopping.Margin = new Padding(2);
            btnBestSellingTopping.Name = "btnBestSellingTopping";
            btnBestSellingTopping.Padding = new Padding(50, 0, 0, 0);
            btnBestSellingTopping.Size = new System.Drawing.Size(212, 66);
            btnBestSellingTopping.TabIndex = 4;
            btnBestSellingTopping.Text = "Topping";
            btnBestSellingTopping.UseVisualStyleBackColor = false;
            btnBestSellingTopping.Click += btnBestSellingTopping_Click;
            // 
            // btnBestSellingDrink
            // 
            btnBestSellingDrink.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBestSellingDrink.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBestSellingDrink.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingDrink.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingDrink.BackgroundImage");
            btnBestSellingDrink.BackgroundImageLayout = ImageLayout.Zoom;
            btnBestSellingDrink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBestSellingDrink.Location = new System.Drawing.Point(491, 36);
            btnBestSellingDrink.Margin = new Padding(2);
            btnBestSellingDrink.Name = "btnBestSellingDrink";
            btnBestSellingDrink.Padding = new Padding(50, 0, 0, 0);
            btnBestSellingDrink.Size = new System.Drawing.Size(212, 66);
            btnBestSellingDrink.TabIndex = 3;
            btnBestSellingDrink.Text = "Drink";
            btnBestSellingDrink.UseVisualStyleBackColor = false;
            btnBestSellingDrink.Click += btnBestSellingDrink_Click;
            // 
            // btnBestSellingFood
            // 
            btnBestSellingFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBestSellingFood.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingFood.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingFood.BackgroundImage");
            btnBestSellingFood.BackgroundImageLayout = ImageLayout.Zoom;
            btnBestSellingFood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingFood.Location = new System.Drawing.Point(126, 36);
            btnBestSellingFood.Margin = new Padding(2);
            btnBestSellingFood.Name = "btnBestSellingFood";
            btnBestSellingFood.Padding = new Padding(50, 0, 0, 0);
            btnBestSellingFood.Size = new System.Drawing.Size(212, 66);
            btnBestSellingFood.TabIndex = 2;
            btnBestSellingFood.Text = "Food";
            btnBestSellingFood.UseVisualStyleBackColor = false;
            btnBestSellingFood.Click += btnBestSellingFood_Click;
            // 
            // plStatistic
            // 
            plStatistic.BackColor = System.Drawing.Color.GreenYellow;
            plStatistic.Controls.Add(billBtn);
            plStatistic.Controls.Add(dtgvStatistic);
            plStatistic.Controls.Add(plTotalProfit);
            plStatistic.Controls.Add(plTotalInvestment);
            plStatistic.Controls.Add(plTotalIncome);
            plStatistic.Location = new System.Drawing.Point(844, 65);
            plStatistic.Margin = new Padding(2);
            plStatistic.Name = "plStatistic";
            plStatistic.Size = new System.Drawing.Size(738, 709);
            plStatistic.TabIndex = 2;
            // 
            // billBtn
            // 
            billBtn.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            billBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            billBtn.Location = new System.Drawing.Point(606, 539);
            billBtn.Margin = new Padding(4);
            billBtn.Name = "billBtn";
            billBtn.Size = new System.Drawing.Size(111, 141);
            billBtn.TabIndex = 10;
            billBtn.Text = "Hoá đơn trong ngày";
            billBtn.UseVisualStyleBackColor = false;
            billBtn.Click += billBtn_Click;
            // 
            // dtgvStatistic
            // 
            dtgvStatistic.AllowUserToOrderColumns = true;
            dtgvStatistic.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dtgvStatistic.BorderStyle = BorderStyle.None;
            dtgvStatistic.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvStatistic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvStatistic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStatistic.Columns.AddRange(new DataGridViewColumn[] { Dish, Type, Sell, Price, Profit });
            dtgvStatistic.EnableHeadersVisualStyles = false;
            dtgvStatistic.Location = new System.Drawing.Point(22, 25);
            dtgvStatistic.Margin = new Padding(2);
            dtgvStatistic.Name = "dtgvStatistic";
            dtgvStatistic.RowHeadersWidth = 62;
            dtgvStatistic.RowTemplate.Height = 33;
            dtgvStatistic.Size = new System.Drawing.Size(695, 484);
            dtgvStatistic.TabIndex = 8;
            // 
            // Dish
            // 
            Dish.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dish.HeaderText = "Món";
            Dish.MinimumWidth = 8;
            Dish.Name = "Dish";
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Loại";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            // 
            // Sell
            // 
            Sell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sell.HeaderText = "Số lượng";
            Sell.MinimumWidth = 8;
            Sell.Name = "Sell";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            // 
            // Profit
            // 
            Profit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Profit.HeaderText = "Lợi nhuận";
            Profit.MinimumWidth = 8;
            Profit.Name = "Profit";
            // 
            // plTotalProfit
            // 
            plTotalProfit.Controls.Add(totalProfitLabel);
            plTotalProfit.Controls.Add(lbTotalProfit);
            plTotalProfit.Location = new System.Drawing.Point(18, 636);
            plTotalProfit.Margin = new Padding(2);
            plTotalProfit.Name = "plTotalProfit";
            plTotalProfit.Size = new System.Drawing.Size(578, 44);
            plTotalProfit.TabIndex = 2;
            // 
            // totalProfitLabel
            // 
            totalProfitLabel.BackColor = System.Drawing.Color.White;
            totalProfitLabel.Location = new System.Drawing.Point(188, 5);
            totalProfitLabel.Margin = new Padding(4, 0, 4, 0);
            totalProfitLabel.Name = "totalProfitLabel";
            totalProfitLabel.Size = new System.Drawing.Size(375, 31);
            totalProfitLabel.TabIndex = 7;
            totalProfitLabel.Text = "0";
            // 
            // lbTotalProfit
            // 
            lbTotalProfit.AutoSize = true;
            lbTotalProfit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalProfit.Location = new System.Drawing.Point(2, 9);
            lbTotalProfit.Margin = new Padding(2, 0, 2, 0);
            lbTotalProfit.Name = "lbTotalProfit";
            lbTotalProfit.Size = new System.Drawing.Size(86, 25);
            lbTotalProfit.TabIndex = 0;
            lbTotalProfit.Text = "Tổng lãi:";
            // 
            // plTotalInvestment
            // 
            plTotalInvestment.Controls.Add(totalInvestmentLabel);
            plTotalInvestment.Controls.Add(lbTotalInvestment);
            plTotalInvestment.Location = new System.Drawing.Point(18, 588);
            plTotalInvestment.Margin = new Padding(2);
            plTotalInvestment.Name = "plTotalInvestment";
            plTotalInvestment.Size = new System.Drawing.Size(578, 44);
            plTotalInvestment.TabIndex = 1;
            // 
            // totalInvestmentLabel
            // 
            totalInvestmentLabel.BackColor = System.Drawing.Color.White;
            totalInvestmentLabel.Location = new System.Drawing.Point(188, 5);
            totalInvestmentLabel.Margin = new Padding(4, 0, 4, 0);
            totalInvestmentLabel.Name = "totalInvestmentLabel";
            totalInvestmentLabel.Size = new System.Drawing.Size(375, 31);
            totalInvestmentLabel.TabIndex = 7;
            totalInvestmentLabel.Text = "0";
            // 
            // lbTotalInvestment
            // 
            lbTotalInvestment.AutoSize = true;
            lbTotalInvestment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalInvestment.Location = new System.Drawing.Point(2, 9);
            lbTotalInvestment.Margin = new Padding(2, 0, 2, 0);
            lbTotalInvestment.Name = "lbTotalInvestment";
            lbTotalInvestment.Size = new System.Drawing.Size(98, 25);
            lbTotalInvestment.TabIndex = 0;
            lbTotalInvestment.Text = "Tổng vốn:";
            // 
            // plTotalIncome
            // 
            plTotalIncome.Controls.Add(totalIncomeLabel);
            plTotalIncome.Controls.Add(lbTotalIncome);
            plTotalIncome.Location = new System.Drawing.Point(18, 539);
            plTotalIncome.Margin = new Padding(2);
            plTotalIncome.Name = "plTotalIncome";
            plTotalIncome.Size = new System.Drawing.Size(578, 44);
            plTotalIncome.TabIndex = 0;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.BackColor = System.Drawing.Color.White;
            totalIncomeLabel.Location = new System.Drawing.Point(188, 5);
            totalIncomeLabel.Margin = new Padding(4, 0, 4, 0);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new System.Drawing.Size(375, 31);
            totalIncomeLabel.TabIndex = 6;
            totalIncomeLabel.Text = "0";
            // 
            // lbTotalIncome
            // 
            lbTotalIncome.AutoSize = true;
            lbTotalIncome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalIncome.Location = new System.Drawing.Point(2, 9);
            lbTotalIncome.Margin = new Padding(2, 0, 2, 0);
            lbTotalIncome.Name = "lbTotalIncome";
            lbTotalIncome.Size = new System.Drawing.Size(154, 25);
            lbTotalIncome.TabIndex = 0;
            lbTotalIncome.Text = "Tổng thành tiền:";
            // 
            // plProfitChart
            // 
            plProfitChart.BackColor = System.Drawing.Color.IndianRed;
            plProfitChart.Controls.Add(chart);
            plProfitChart.Location = new System.Drawing.Point(0, 65);
            plProfitChart.Margin = new Padding(2);
            plProfitChart.Name = "plProfitChart";
            plProfitChart.Size = new System.Drawing.Size(848, 538);
            plProfitChart.TabIndex = 0;
            // 
            // chart
            // 
            chart.Enabled = false;
            chart.Location = new System.Drawing.Point(45, 58);
            chart.Margin = new Padding(6);
            chart.Name = "chart";
            chart.Size = new System.Drawing.Size(750, 436);
            chart.TabIndex = 0;
            // 
            // dropdownPanel
            // 
            dropdownPanel.Controls.Add(allTimeButton);
            dropdownPanel.Controls.Add(oneMonthButton);
            dropdownPanel.Controls.Add(todayButton);
            dropdownPanel.Controls.Add(dropdownButton);
            dropdownPanel.Location = new System.Drawing.Point(1276, 8);
            dropdownPanel.Margin = new Padding(4);
            dropdownPanel.MaximumSize = new System.Drawing.Size(312, 250);
            dropdownPanel.MinimumSize = new System.Drawing.Size(312, 62);
            dropdownPanel.Name = "dropdownPanel";
            dropdownPanel.Size = new System.Drawing.Size(312, 62);
            dropdownPanel.TabIndex = 5;
            // 
            // allTimeButton
            // 
            allTimeButton.BackColor = System.Drawing.Color.Azure;
            allTimeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            allTimeButton.Location = new System.Drawing.Point(0, 188);
            allTimeButton.Margin = new Padding(4);
            allTimeButton.Name = "allTimeButton";
            allTimeButton.Size = new System.Drawing.Size(312, 62);
            allTimeButton.TabIndex = 3;
            allTimeButton.Text = "Toàn thời gian";
            allTimeButton.UseVisualStyleBackColor = false;
            allTimeButton.Click += allTimeButton_Click;
            // 
            // oneMonthButton
            // 
            oneMonthButton.BackColor = System.Drawing.Color.Azure;
            oneMonthButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            oneMonthButton.Location = new System.Drawing.Point(0, 125);
            oneMonthButton.Margin = new Padding(4);
            oneMonthButton.Name = "oneMonthButton";
            oneMonthButton.Size = new System.Drawing.Size(312, 62);
            oneMonthButton.TabIndex = 2;
            oneMonthButton.Text = "Tháng hiện tại";
            oneMonthButton.UseVisualStyleBackColor = false;
            oneMonthButton.Click += oneMonthButton_Click;
            // 
            // todayButton
            // 
            todayButton.BackColor = System.Drawing.Color.Azure;
            todayButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            todayButton.Location = new System.Drawing.Point(0, 62);
            todayButton.Margin = new Padding(4);
            todayButton.Name = "todayButton";
            todayButton.Size = new System.Drawing.Size(312, 62);
            todayButton.TabIndex = 1;
            todayButton.Text = "Hôm nay";
            todayButton.UseVisualStyleBackColor = false;
            todayButton.Click += todayButton_Click;
            // 
            // dropdownButton
            // 
            dropdownButton.BackColor = System.Drawing.Color.Silver;
            dropdownButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dropdownButton.Location = new System.Drawing.Point(0, 0);
            dropdownButton.Margin = new Padding(4);
            dropdownButton.Name = "dropdownButton";
            dropdownButton.Size = new System.Drawing.Size(312, 62);
            dropdownButton.TabIndex = 0;
            dropdownButton.Text = "Loại thống kê";
            dropdownButton.UseVisualStyleBackColor = false;
            dropdownButton.Click += dropdownButton_Click;
            // 
            // dropdownTimer
            // 
            dropdownTimer.Interval = 10;
            dropdownTimer.Tick += dropdownTimer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1595, 782);
            Controls.Add(dropdownPanel);
            Controls.Add(panelFull);
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1617, 838);
            MinimumSize = new System.Drawing.Size(1617, 838);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doanh thu";
            panelFull.ResumeLayout(false);
            bestSellingPanel.ResumeLayout(false);
            bestSellingPanel.PerformLayout();
            plStatistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStatistic).EndInit();
            plTotalProfit.ResumeLayout(false);
            plTotalProfit.PerformLayout();
            plTotalInvestment.ResumeLayout(false);
            plTotalInvestment.PerformLayout();
            plTotalIncome.ResumeLayout(false);
            plTotalIncome.PerformLayout();
            plProfitChart.ResumeLayout(false);
            dropdownPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelFull;
        private System.Windows.Forms.Panel plStatistic;
        private System.Windows.Forms.Panel plTotalProfit;
        private System.Windows.Forms.Label lbTotalProfit;
        private System.Windows.Forms.Panel plTotalInvestment;
        private System.Windows.Forms.Label lbTotalInvestment;
        private System.Windows.Forms.Panel plTotalIncome;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.Panel plProfitChart;
        private System.Windows.Forms.DataGridView dtgvStatistic;
        private ScottPlot.FormsPlot chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Panel bestSellingPanel;
        private System.Windows.Forms.Button btnBestSellingTopping;
        private System.Windows.Forms.Button btnBestSellingDrink;
        private System.Windows.Forms.Button btnBestSellingFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dropdownPanel;
        private System.Windows.Forms.Button dropdownButton;
        private System.Windows.Forms.Button allTimeButton;
        private System.Windows.Forms.Button oneMonthButton;
        private System.Windows.Forms.Button todayButton;
        private System.Windows.Forms.Timer dropdownTimer;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label totalProfitLabel;
        private System.Windows.Forms.Label totalInvestmentLabel;
        private Label updateTimeLabel;
        private Button btnBestSellingSpecial;
        private Label statisticsTypeLabel;
        private Button billBtn;
    }
}