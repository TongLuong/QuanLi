namespace QuanLi
{
    partial class fBSSpecial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBSSpecial));
            dtgvBSSpecial = new System.Windows.Forms.DataGridView();
            SpecialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvBSSpecial).BeginInit();
            SuspendLayout();
            // 
            // dtgvBSSpecial
            // 
            dtgvBSSpecial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dtgvBSSpecial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgvBSSpecial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvBSSpecial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBSSpecial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SpecialName, Sell, Profit });
            dtgvBSSpecial.EnableHeadersVisualStyles = false;
            dtgvBSSpecial.Location = new System.Drawing.Point(10, 10);
            dtgvBSSpecial.Margin = new System.Windows.Forms.Padding(2);
            dtgvBSSpecial.Name = "dtgvBSSpecial";
            dtgvBSSpecial.RowHeadersWidth = 62;
            dtgvBSSpecial.RowTemplate.Height = 33;
            dtgvBSSpecial.Size = new System.Drawing.Size(868, 470);
            dtgvBSSpecial.TabIndex = 1;
            // 
            // SpecialName
            // 
            SpecialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            SpecialName.HeaderText = "Tên món ăn";
            SpecialName.MinimumWidth = 8;
            SpecialName.Name = "SpecialName";
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
            // fBSSpecial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(887, 489);
            Controls.Add(dtgvBSSpecial);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            Name = "fBSSpecial";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Món đặc biệt bán chạy nhất";
            ((System.ComponentModel.ISupportInitialize)dtgvBSSpecial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBSSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}