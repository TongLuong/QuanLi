﻿namespace QuanLi
{
    partial class BillStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dtgvBills = new System.Windows.Forms.DataGridView();
            billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            billIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            averagePrice = new System.Windows.Forms.Label();
            mostValueBillPrice = new System.Windows.Forms.Label();
            mostValueBillID = new System.Windows.Forms.Label();
            mostValueBillLabel = new System.Windows.Forms.Label();
            numberOfBills = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgvBills).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvBills
            // 
            dtgvBills.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgvBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dtgvBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { billID, billIncome });
            dtgvBills.EnableHeadersVisualStyles = false;
            dtgvBills.Location = new System.Drawing.Point(14, 12);
            dtgvBills.Margin = new System.Windows.Forms.Padding(2);
            dtgvBills.Name = "dtgvBills";
            dtgvBills.RowHeadersWidth = 62;
            dtgvBills.RowTemplate.Height = 33;
            dtgvBills.Size = new System.Drawing.Size(561, 325);
            dtgvBills.TabIndex = 2;
            // 
            // billID
            // 
            billID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            billID.HeaderText = "Mã hoá đơn";
            billID.MinimumWidth = 8;
            billID.Name = "billID";
            // 
            // billIncome
            // 
            billIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            billIncome.HeaderText = "Doanh thu";
            billIncome.MinimumWidth = 8;
            billIncome.Name = "billIncome";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Info;
            panel1.Controls.Add(averagePrice);
            panel1.Controls.Add(mostValueBillPrice);
            panel1.Controls.Add(mostValueBillID);
            panel1.Controls.Add(mostValueBillLabel);
            panel1.Controls.Add(numberOfBills);
            panel1.Location = new System.Drawing.Point(14, 344);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(561, 244);
            panel1.TabIndex = 4;
            // 
            // averagePrice
            // 
            averagePrice.BackColor = System.Drawing.SystemColors.Info;
            averagePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            averagePrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            averagePrice.Location = new System.Drawing.Point(4, 198);
            averagePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            averagePrice.Name = "averagePrice";
            averagePrice.Size = new System.Drawing.Size(550, 31);
            averagePrice.TabIndex = 8;
            averagePrice.Text = "Doanh thu trung bình :";
            averagePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mostValueBillPrice
            // 
            mostValueBillPrice.BackColor = System.Drawing.SystemColors.Info;
            mostValueBillPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mostValueBillPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mostValueBillPrice.Location = new System.Drawing.Point(23, 149);
            mostValueBillPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mostValueBillPrice.Name = "mostValueBillPrice";
            mostValueBillPrice.Size = new System.Drawing.Size(531, 31);
            mostValueBillPrice.TabIndex = 7;
            mostValueBillPrice.Text = "+ Doanh thu :";
            mostValueBillPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mostValueBillID
            // 
            mostValueBillID.BackColor = System.Drawing.SystemColors.Info;
            mostValueBillID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mostValueBillID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mostValueBillID.Location = new System.Drawing.Point(23, 107);
            mostValueBillID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mostValueBillID.Name = "mostValueBillID";
            mostValueBillID.Size = new System.Drawing.Size(531, 31);
            mostValueBillID.TabIndex = 6;
            mostValueBillID.Text = "+ Mã hoá đơn :";
            mostValueBillID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mostValueBillLabel
            // 
            mostValueBillLabel.BackColor = System.Drawing.SystemColors.Info;
            mostValueBillLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mostValueBillLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mostValueBillLabel.Location = new System.Drawing.Point(4, 62);
            mostValueBillLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mostValueBillLabel.Name = "mostValueBillLabel";
            mostValueBillLabel.Size = new System.Drawing.Size(550, 31);
            mostValueBillLabel.TabIndex = 5;
            mostValueBillLabel.Text = "Hoá đơn có doanh thu cao nhất :";
            mostValueBillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberOfBills
            // 
            numberOfBills.BackColor = System.Drawing.SystemColors.Info;
            numberOfBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            numberOfBills.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numberOfBills.Location = new System.Drawing.Point(4, 14);
            numberOfBills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numberOfBills.Name = "numberOfBills";
            numberOfBills.Size = new System.Drawing.Size(554, 31);
            numberOfBills.TabIndex = 4;
            numberOfBills.Text = "Tổng số hoá đơn :";
            numberOfBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BillStatistics
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(582, 612);
            Controls.Add(panel1);
            Controls.Add(dtgvBills);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "BillStatistics";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Thống kê hoá hơn trong ngày";
            ((System.ComponentModel.ISupportInitialize)dtgvBills).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mostValueBillLabel;
        private System.Windows.Forms.Label numberOfBills;
        private System.Windows.Forms.Label mostValueBillPrice;
        private System.Windows.Forms.Label mostValueBillID;
        private System.Windows.Forms.Label averagePrice;

        // ID - Total Money
        // Label : Tổng số bill, Đơn hàng doanh thu cao nhất (ID + Money), Average money
    }
}