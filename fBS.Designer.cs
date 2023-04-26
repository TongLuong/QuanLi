namespace QuanLi
{
    partial class fBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBS));
            dtgvBS = new System.Windows.Forms.DataGridView();
            FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvBS).BeginInit();
            SuspendLayout();
            // 
            // dtgvBS
            // 
            dtgvBS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dtgvBS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgvBS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FoodName, Sell, Profit });
            dtgvBS.EnableHeadersVisualStyles = false;
            dtgvBS.Location = new System.Drawing.Point(13, 15);
            dtgvBS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dtgvBS.Name = "dtgvBS";
            dtgvBS.ReadOnly = true;
            dtgvBS.RowHeadersWidth = 62;
            dtgvBS.RowTemplate.Height = 33;
            dtgvBS.Size = new System.Drawing.Size(869, 469);
            dtgvBS.TabIndex = 2;
            // 
            // FoodName
            // 
            FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            FoodName.HeaderText = "Tên món ăn";
            FoodName.MinimumWidth = 8;
            FoodName.Name = "FoodName";
            FoodName.ReadOnly = true;
            // 
            // Sell
            // 
            Sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sell.HeaderText = "Số đĩa bán được";
            Sell.MinimumWidth = 8;
            Sell.Name = "Sell";
            Sell.ReadOnly = true;
            // 
            // Profit
            // 
            Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Profit.HeaderText = "Lợi nhuận";
            Profit.MinimumWidth = 8;
            Profit.Name = "Profit";
            Profit.ReadOnly = true;
            // 
            // fBS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(896, 497);
            Controls.Add(dtgvBS);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(914, 544);
            MinimumSize = new System.Drawing.Size(914, 544);
            Name = "fBS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "fBS";
            ((System.ComponentModel.ISupportInitialize)dtgvBS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}