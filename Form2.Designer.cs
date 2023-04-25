
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            panelFull.Location = new System.Drawing.Point(6, 6);
            panelFull.Margin = new Padding(2);
            panelFull.Name = "panelFull";
            panelFull.Size = new System.Drawing.Size(1265, 619);
            panelFull.TabIndex = 0;
            // 
            // statisticsTypeLabel
            // 
            statisticsTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            statisticsTypeLabel.Location = new System.Drawing.Point(675, 0);
            statisticsTypeLabel.Name = "statisticsTypeLabel";
            statisticsTypeLabel.Size = new System.Drawing.Size(334, 50);
            statisticsTypeLabel.TabIndex = 6;
            statisticsTypeLabel.Text = "Thống kê trong hôm nay";
            statisticsTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            updateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            updateTimeLabel.Location = new System.Drawing.Point(0, 0);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(403, 50);
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
            bestSellingPanel.Location = new System.Drawing.Point(0, 476);
            bestSellingPanel.Name = "bestSellingPanel";
            bestSellingPanel.Size = new System.Drawing.Size(678, 143);
            bestSellingPanel.TabIndex = 4;
            // 
            // btnBestSellingSpecial
            // 
            btnBestSellingSpecial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBestSellingSpecial.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnBestSellingSpecial.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnBestSellingSpecial.BackgroundImage");
            btnBestSellingSpecial.BackgroundImageLayout = ImageLayout.Zoom;
            btnBestSellingSpecial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBestSellingSpecial.Location = new System.Drawing.Point(396, 85);
            btnBestSellingSpecial.Margin = new Padding(2);
            btnBestSellingSpecial.Name = "btnBestSellingSpecial";
            btnBestSellingSpecial.Padding = new Padding(40, 0, 0, 0);
            btnBestSellingSpecial.Size = new System.Drawing.Size(170, 53);
            btnBestSellingSpecial.TabIndex = 6;
            btnBestSellingSpecial.Text = "Special";
            btnBestSellingSpecial.UseVisualStyleBackColor = false;
            btnBestSellingSpecial.Click += btnBestSellingSpecial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(287, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 23);
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
            btnBestSellingTopping.Location = new System.Drawing.Point(104, 85);
            btnBestSellingTopping.Margin = new Padding(2);
            btnBestSellingTopping.Name = "btnBestSellingTopping";
            btnBestSellingTopping.Padding = new Padding(40, 0, 0, 0);
            btnBestSellingTopping.Size = new System.Drawing.Size(170, 53);
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
            btnBestSellingDrink.Location = new System.Drawing.Point(396, 29);
            btnBestSellingDrink.Margin = new Padding(2);
            btnBestSellingDrink.Name = "btnBestSellingDrink";
            btnBestSellingDrink.Padding = new Padding(40, 0, 0, 0);
            btnBestSellingDrink.Size = new System.Drawing.Size(170, 53);
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
            btnBestSellingFood.Location = new System.Drawing.Point(104, 29);
            btnBestSellingFood.Margin = new Padding(2);
            btnBestSellingFood.Name = "btnBestSellingFood";
            btnBestSellingFood.Padding = new Padding(40, 0, 0, 0);
            btnBestSellingFood.Size = new System.Drawing.Size(170, 53);
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
            plStatistic.Location = new System.Drawing.Point(675, 52);
            plStatistic.Margin = new Padding(2);
            plStatistic.Name = "plStatistic";
            plStatistic.Size = new System.Drawing.Size(590, 567);
            plStatistic.TabIndex = 2;
            // 
            // billBtn
            // 
            billBtn.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            billBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            billBtn.Location = new System.Drawing.Point(498, 431);
            billBtn.Name = "billBtn";
            billBtn.Size = new System.Drawing.Size(89, 123);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvStatistic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvStatistic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStatistic.Columns.AddRange(new DataGridViewColumn[] { Dish, Type, Sell, Price, Profit });
            dtgvStatistic.EnableHeadersVisualStyles = false;
            dtgvStatistic.Location = new System.Drawing.Point(35, 33);
            dtgvStatistic.Margin = new Padding(2);
            dtgvStatistic.Name = "dtgvStatistic";
            dtgvStatistic.RowHeadersWidth = 62;
            dtgvStatistic.RowTemplate.Height = 33;
            dtgvStatistic.Size = new System.Drawing.Size(556, 387);
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
            plTotalProfit.Location = new System.Drawing.Point(14, 519);
            plTotalProfit.Margin = new Padding(2);
            plTotalProfit.Name = "plTotalProfit";
            plTotalProfit.Size = new System.Drawing.Size(462, 35);
            plTotalProfit.TabIndex = 2;
            // 
            // totalProfitLabel
            // 
            totalProfitLabel.BackColor = System.Drawing.Color.White;
            totalProfitLabel.Location = new System.Drawing.Point(150, 4);
            totalProfitLabel.Name = "totalProfitLabel";
            totalProfitLabel.Size = new System.Drawing.Size(300, 25);
            totalProfitLabel.TabIndex = 7;
            totalProfitLabel.Text = "0";
            // 
            // lbTotalProfit
            // 
            lbTotalProfit.AutoSize = true;
            lbTotalProfit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalProfit.Location = new System.Drawing.Point(2, 7);
            lbTotalProfit.Margin = new Padding(2, 0, 2, 0);
            lbTotalProfit.Name = "lbTotalProfit";
            lbTotalProfit.Size = new System.Drawing.Size(69, 20);
            lbTotalProfit.TabIndex = 0;
            lbTotalProfit.Text = "Tổng lãi:";
            // 
            // plTotalInvestment
            // 
            plTotalInvestment.Controls.Add(totalInvestmentLabel);
            plTotalInvestment.Controls.Add(lbTotalInvestment);
            plTotalInvestment.Location = new System.Drawing.Point(14, 471);
            plTotalInvestment.Margin = new Padding(2);
            plTotalInvestment.Name = "plTotalInvestment";
            plTotalInvestment.Size = new System.Drawing.Size(462, 35);
            plTotalInvestment.TabIndex = 1;
            // 
            // totalInvestmentLabel
            // 
            totalInvestmentLabel.BackColor = System.Drawing.Color.White;
            totalInvestmentLabel.Location = new System.Drawing.Point(150, 4);
            totalInvestmentLabel.Name = "totalInvestmentLabel";
            totalInvestmentLabel.Size = new System.Drawing.Size(300, 25);
            totalInvestmentLabel.TabIndex = 7;
            totalInvestmentLabel.Text = "0";
            // 
            // lbTotalInvestment
            // 
            lbTotalInvestment.AutoSize = true;
            lbTotalInvestment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalInvestment.Location = new System.Drawing.Point(2, 7);
            lbTotalInvestment.Margin = new Padding(2, 0, 2, 0);
            lbTotalInvestment.Name = "lbTotalInvestment";
            lbTotalInvestment.Size = new System.Drawing.Size(79, 20);
            lbTotalInvestment.TabIndex = 0;
            lbTotalInvestment.Text = "Tổng vốn:";
            // 
            // plTotalIncome
            // 
            plTotalIncome.Controls.Add(totalIncomeLabel);
            plTotalIncome.Controls.Add(lbTotalIncome);
            plTotalIncome.Location = new System.Drawing.Point(16, 424);
            plTotalIncome.Margin = new Padding(2);
            plTotalIncome.Name = "plTotalIncome";
            plTotalIncome.Size = new System.Drawing.Size(460, 35);
            plTotalIncome.TabIndex = 0;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.BackColor = System.Drawing.Color.White;
            totalIncomeLabel.Location = new System.Drawing.Point(150, 4);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new System.Drawing.Size(300, 25);
            totalIncomeLabel.TabIndex = 6;
            totalIncomeLabel.Text = "0";
            // 
            // lbTotalIncome
            // 
            lbTotalIncome.AutoSize = true;
            lbTotalIncome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalIncome.Location = new System.Drawing.Point(2, 7);
            lbTotalIncome.Margin = new Padding(2, 0, 2, 0);
            lbTotalIncome.Name = "lbTotalIncome";
            lbTotalIncome.Size = new System.Drawing.Size(125, 20);
            lbTotalIncome.TabIndex = 0;
            lbTotalIncome.Text = "Tổng thành tiền:";
            // 
            // plProfitChart
            // 
            plProfitChart.BackColor = System.Drawing.Color.IndianRed;
            plProfitChart.Controls.Add(chart);
            plProfitChart.Location = new System.Drawing.Point(0, 52);
            plProfitChart.Margin = new Padding(2);
            plProfitChart.Name = "plProfitChart";
            plProfitChart.Size = new System.Drawing.Size(678, 430);
            plProfitChart.TabIndex = 0;
            // 
            // chart
            // 
            chart.Enabled = false;
            chart.Location = new System.Drawing.Point(36, 46);
            chart.Margin = new Padding(5);
            chart.Name = "chart";
            chart.Size = new System.Drawing.Size(600, 349);
            chart.TabIndex = 0;
            // 
            // dropdownPanel
            // 
            dropdownPanel.Controls.Add(allTimeButton);
            dropdownPanel.Controls.Add(oneMonthButton);
            dropdownPanel.Controls.Add(todayButton);
            dropdownPanel.Controls.Add(dropdownButton);
            dropdownPanel.Location = new System.Drawing.Point(1021, 6);
            dropdownPanel.MaximumSize = new System.Drawing.Size(250, 200);
            dropdownPanel.MinimumSize = new System.Drawing.Size(250, 50);
            dropdownPanel.Name = "dropdownPanel";
            dropdownPanel.Size = new System.Drawing.Size(250, 50);
            dropdownPanel.TabIndex = 5;
            // 
            // allTimeButton
            // 
            allTimeButton.BackColor = System.Drawing.Color.Azure;
            allTimeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            allTimeButton.Location = new System.Drawing.Point(0, 150);
            allTimeButton.Name = "allTimeButton";
            allTimeButton.Size = new System.Drawing.Size(250, 50);
            allTimeButton.TabIndex = 3;
            allTimeButton.Text = "Toàn thời gian";
            allTimeButton.UseVisualStyleBackColor = false;
            allTimeButton.Click += allTimeButton_Click;
            // 
            // oneMonthButton
            // 
            oneMonthButton.BackColor = System.Drawing.Color.Azure;
            oneMonthButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            oneMonthButton.Location = new System.Drawing.Point(0, 100);
            oneMonthButton.Name = "oneMonthButton";
            oneMonthButton.Size = new System.Drawing.Size(250, 50);
            oneMonthButton.TabIndex = 2;
            oneMonthButton.Text = "Tháng hiện tại";
            oneMonthButton.UseVisualStyleBackColor = false;
            oneMonthButton.Click += oneMonthButton_Click;
            // 
            // todayButton
            // 
            todayButton.BackColor = System.Drawing.Color.Azure;
            todayButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            todayButton.Location = new System.Drawing.Point(0, 50);
            todayButton.Name = "todayButton";
            todayButton.Size = new System.Drawing.Size(250, 50);
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
            dropdownButton.Name = "dropdownButton";
            dropdownButton.Size = new System.Drawing.Size(250, 50);
            dropdownButton.TabIndex = 0;
            dropdownButton.Text = "Loại thống kê";
            dropdownButton.UseVisualStyleBackColor = false;
            dropdownButton.Click += dropdownButton_Click;
            // 
            // dropdownTimer
            // 
            dropdownTimer.Tick += dropdownTimer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1280, 635);
            Controls.Add(dropdownPanel);
            Controls.Add(panelFull);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1298, 682);
            MinimumSize = new System.Drawing.Size(1298, 682);
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