namespace QuanLi
{
    partial class DeleteItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItem));
            MenuAll = new System.Windows.Forms.DataGridView();
            DeleteBtn = new System.Windows.Forms.Button();
            CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)MenuAll).BeginInit();
            SuspendLayout();
            // 
            // MenuAll
            // 
            MenuAll.AllowUserToAddRows = false;
            MenuAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MenuAll.Location = new System.Drawing.Point(12, 49);
            MenuAll.Name = "MenuAll";
            MenuAll.ReadOnly = true;
            MenuAll.RowHeadersWidth = 51;
            MenuAll.RowTemplate.Height = 29;
            MenuAll.Size = new System.Drawing.Size(954, 458);
            MenuAll.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new System.Drawing.Point(872, 14);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new System.Drawing.Size(94, 29);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new System.Drawing.Point(772, 14);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(94, 29);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Hủy";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // DeleteItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(975, 519);
            ControlBox = false;
            Controls.Add(CancelBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(MenuAll);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "DeleteItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Xóa Món";
            ((System.ComponentModel.ISupportInitialize)MenuAll).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView MenuAll;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}