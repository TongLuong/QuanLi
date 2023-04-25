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
            label5 = new System.Windows.Forms.Label();
            ItemType = new System.Windows.Forms.ComboBox();
            addImage = new System.Windows.Forms.Button();
            ItemImage = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(3, 136);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Chi phí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(13, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(315, 23);
            label4.TabIndex = 3;
            label4.Text = "Nhập thông tin cho sản phẩm mới";
            // 
            // ItemName
            // 
            ItemName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemName.Location = new System.Drawing.Point(85, 46);
            ItemName.Name = "ItemName";
            ItemName.Size = new System.Drawing.Size(243, 25);
            ItemName.TabIndex = 4;
            // 
            // ItemPrice
            // 
            ItemPrice.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemPrice.Location = new System.Drawing.Point(85, 89);
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Size = new System.Drawing.Size(243, 25);
            ItemPrice.TabIndex = 5;
            // 
            // ItemExpense
            // 
            ItemExpense.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemExpense.Location = new System.Drawing.Point(85, 133);
            ItemExpense.Name = "ItemExpense";
            ItemExpense.Size = new System.Drawing.Size(243, 25);
            ItemExpense.TabIndex = 6;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(223, 260);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(105, 40);
            Cancel.TabIndex = 7;
            Cancel.Text = "Hủy bỏ";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Accept
            // 
            Accept.Location = new System.Drawing.Point(113, 260);
            Accept.Name = "Accept";
            Accept.Size = new System.Drawing.Size(105, 40);
            Accept.TabIndex = 8;
            Accept.Text = "OK";
            Accept.UseVisualStyleBackColor = true;
            Accept.Click += Accept_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 179);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Phân loại";
            // 
            // ItemType
            // 
            ItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            ItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            ItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ItemType.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemType.FormattingEnabled = true;
            ItemType.Location = new System.Drawing.Point(85, 176);
            ItemType.Name = "ItemType";
            ItemType.Size = new System.Drawing.Size(125, 25);
            ItemType.TabIndex = 10;
            // 
            // addImage
            // 
            addImage.Location = new System.Drawing.Point(3, 260);
            addImage.Name = "addImage";
            addImage.Size = new System.Drawing.Size(105, 40);
            addImage.TabIndex = 11;
            addImage.Text = "Thêm Ảnh";
            addImage.UseVisualStyleBackColor = true;
            addImage.Click += addImage_Click;
            // 
            // ItemImage
            // 
            ItemImage.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemImage.Location = new System.Drawing.Point(85, 221);
            ItemImage.Name = "ItemImage";
            ItemImage.Size = new System.Drawing.Size(243, 25);
            ItemImage.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(3, 224);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 20);
            label6.TabIndex = 13;
            label6.Text = "Hình ảnh";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(340, 300);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(ItemImage);
            Controls.Add(addImage);
            Controls.Add(ItemType);
            Controls.Add(label5);
            Controls.Add(Accept);
            Controls.Add(Cancel);
            Controls.Add(ItemExpense);
            Controls.Add(ItemPrice);
            Controls.Add(ItemName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Load += AddItem_Load;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ItemType;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.TextBox ItemImage;
        private System.Windows.Forms.Label label6;
    }
}