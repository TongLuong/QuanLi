namespace QuanLi
{
    partial class AddItem
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ItemName = new System.Windows.Forms.TextBox();
            ItemPrice = new System.Windows.Forms.TextBox();
            ItemExpense = new System.Windows.Forms.TextBox();
            Cancel = new System.Windows.Forms.Button();
            Accept = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 133);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Chi phí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(12, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(248, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập thông tin cho sản phẩm mới";
            // 
            // ItemName
            // 
            ItemName.Location = new System.Drawing.Point(85, 46);
            ItemName.Name = "ItemName";
            ItemName.Size = new System.Drawing.Size(178, 27);
            ItemName.TabIndex = 4;
            // 
            // ItemPrice
            // 
            ItemPrice.Location = new System.Drawing.Point(85, 89);
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Size = new System.Drawing.Size(178, 27);
            ItemPrice.TabIndex = 5;
            // 
            // ItemExpense
            // 
            ItemExpense.Location = new System.Drawing.Point(85, 133);
            ItemExpense.Name = "ItemExpense";
            ItemExpense.Size = new System.Drawing.Size(178, 27);
            ItemExpense.TabIndex = 6;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(169, 166);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(94, 29);
            Cancel.TabIndex = 7;
            Cancel.Text = "Hủy bỏ";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Accept
            // 
            Accept.Location = new System.Drawing.Point(69, 166);
            Accept.Name = "Accept";
            Accept.Size = new System.Drawing.Size(94, 29);
            Accept.TabIndex = 8;
            Accept.Text = "OK";
            Accept.UseVisualStyleBackColor = true;
            Accept.Click += Accept_Click;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(273, 204);
            Controls.Add(Accept);
            Controls.Add(Cancel);
            Controls.Add(ItemExpense);
            Controls.Add(ItemPrice);
            Controls.Add(ItemName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AddItemcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox ItemPrice;
        private System.Windows.Forms.TextBox ItemExpense;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
    }
}