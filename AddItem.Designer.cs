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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.itemExpense = new System.Windows.Forms.TextBox();
            Cancel = new System.Windows.Forms.Button();
            Accept = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            this.itemType = new System.Windows.Forms.ComboBox();
            this.addImage = new System.Windows.Forms.Button();
            itemImage = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(8, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(8, 133);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Chi phí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(13, 6);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(315, 23);
            label4.TabIndex = 3;
            label4.Text = "Nhập thông tin cho sản phẩm mới";
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemName.Location = new System.Drawing.Point(90, 43);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(243, 25);
            this.itemName.TabIndex = 4;
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemPrice.Location = new System.Drawing.Point(90, 86);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(243, 25);
            this.itemPrice.TabIndex = 5;
            // 
            // itemExpense
            // 
            this.itemExpense.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemExpense.Location = new System.Drawing.Point(90, 130);
            this.itemExpense.Name = "itemExpense";
            this.itemExpense.Size = new System.Drawing.Size(243, 25);
            this.itemExpense.TabIndex = 6;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(228, 257);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(105, 40);
            Cancel.TabIndex = 7;
            Cancel.Text = "Hủy bỏ";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Accept
            // 
            Accept.Location = new System.Drawing.Point(117, 257);
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
            label5.Location = new System.Drawing.Point(8, 176);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Phân loại";
            // 
            // itemType
            // 
            this.itemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemType.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemType.FormattingEnabled = true;
            this.itemType.Location = new System.Drawing.Point(90, 173);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(125, 25);
            this.itemType.TabIndex = 10;
            // 
            // AddImage
            // 
            this.addImage.Location = new System.Drawing.Point(8, 257);
            this.addImage.Name = "AddImage";
            this.addImage.Size = new System.Drawing.Size(105, 40);
            this.addImage.TabIndex = 11;
            this.addImage.Text = "Thêm Ảnh";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += this.AddImage_Click;
            // 
            // itemImage
            // 
            itemImage.Enabled = false;
            itemImage.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            itemImage.Location = new System.Drawing.Point(90, 218);
            itemImage.Name = "itemImage";
            itemImage.Size = new System.Drawing.Size(243, 25);
            itemImage.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(8, 221);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 20);
            label6.TabIndex = 13;
            label6.Text = "Hình ảnh";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(340, 304);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(itemImage);
            Controls.Add(this.addImage);
            Controls.Add(this.itemType);
            Controls.Add(label5);
            Controls.Add(Accept);
            Controls.Add(Cancel);
            Controls.Add(this.itemExpense);
            Controls.Add(this.itemPrice);
            Controls.Add(this.itemName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(358, 322);
            MinimumSize = new System.Drawing.Size(358, 322);
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
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.TextBox itemExpense;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox itemType;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.TextBox itemImage;
        private System.Windows.Forms.Label label6;
    }
}