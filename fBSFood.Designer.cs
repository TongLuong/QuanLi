namespace QuanLi
{
    partial class fBSFood
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
            dtgvBSFood = new System.Windows.Forms.DataGridView();
            Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FoodImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvBSFood).BeginInit();
            SuspendLayout();
            // 
            // dtgvBSFood
            // 
            dtgvBSFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dtgvBSFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgvBSFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvBSFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBSFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Rank, FoodName, FoodImage, Sell, Profit });
            dtgvBSFood.EnableHeadersVisualStyles = false;
            dtgvBSFood.Location = new System.Drawing.Point(12, 12);
            dtgvBSFood.Name = "dtgvBSFood";
            dtgvBSFood.RowHeadersWidth = 62;
            dtgvBSFood.RowTemplate.Height = 33;
            dtgvBSFood.Size = new System.Drawing.Size(1085, 587);
            dtgvBSFood.TabIndex = 1;
            // 
            // Rank
            // 
            Rank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Rank.HeaderText = "Thứ hạng";
            Rank.MinimumWidth = 8;
            Rank.Name = "Rank";
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
            // fBSFood
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1109, 611);
            Controls.Add(dtgvBSFood);
            Name = "fBSFood";
            Text = "Món ăn bán chạy nhất";
            ((System.ComponentModel.ISupportInitialize)dtgvBSFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBSFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}