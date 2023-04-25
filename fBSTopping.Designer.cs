using System.Collections.Generic;

namespace QuanLi
{
    partial class fBSTopping
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
            dtgvBSTopping = new System.Windows.Forms.DataGridView();
            FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FoodImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvBSTopping).BeginInit();
            SuspendLayout();
            // 
            // dtgvBSTopping
            // 
            dtgvBSTopping.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dtgvBSTopping.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgvBSTopping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvBSTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBSTopping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FoodName, FoodImage, Sell, Profit });
            dtgvBSTopping.EnableHeadersVisualStyles = false;
            dtgvBSTopping.Location = new System.Drawing.Point(10, 10);
            dtgvBSTopping.Margin = new System.Windows.Forms.Padding(2);
            dtgvBSTopping.Name = "dtgvBSTopping";
            dtgvBSTopping.RowHeadersWidth = 62;
            dtgvBSTopping.RowTemplate.Height = 33;
            dtgvBSTopping.Size = new System.Drawing.Size(868, 470);
            dtgvBSTopping.TabIndex = 3;
            // 
            // FoodName
            // 
            FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            FoodName.HeaderText = "Tên món ăn";
            FoodName.MinimumWidth = 8;
            FoodName.Name = "FoodName";
            // 
            // FoodImage
            // 
            FoodImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            FoodImage.HeaderText = "Hình ảnh";
            FoodImage.MinimumWidth = 8;
            FoodImage.Name = "FoodImage";
            // 
            // Sell
            // 
            Sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sell.HeaderText = "Số đĩa bán được";
            Sell.MinimumWidth = 8;
            Sell.Name = "Sell";
            // 
            // Profit
            // 
            Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Profit.HeaderText = "Lợi nhuận";
            Profit.MinimumWidth = 8;
            Profit.Name = "Profit";
            // 
            // fBSTopping
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(887, 495);
            Controls.Add(dtgvBSTopping);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "fBSTopping";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Topping bán chạy nhất";
            ((System.ComponentModel.ISupportInitialize)dtgvBSTopping).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBSTopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}