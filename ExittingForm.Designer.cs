namespace QuanLi
{
    partial class ExittingForm
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
            Save = new System.Windows.Forms.Button();
            DSave = new System.Windows.Forms.Button();
            Cancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(284, 20);
            label1.TabIndex = 0;
            label1.Text = "Bạn có muốn lưu lại dữ liệu không?";
            // 
            // Save
            // 
            Save.Location = new System.Drawing.Point(9, 42);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(94, 29);
            Save.TabIndex = 1;
            Save.Text = "Lưu";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // DSave
            // 
            DSave.Location = new System.Drawing.Point(109, 42);
            DSave.Name = "DSave";
            DSave.Size = new System.Drawing.Size(94, 29);
            DSave.TabIndex = 2;
            DSave.Text = "Không lưu";
            DSave.UseVisualStyleBackColor = true;
            DSave.Click += DSave_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(209, 42);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(94, 29);
            Cancel.TabIndex = 3;
            Cancel.Text = "Hủy bỏ";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // ExittingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(312, 80);
            Controls.Add(Cancel);
            Controls.Add(DSave);
            Controls.Add(Save);
            Controls.Add(label1);
            Name = "ExittingForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button DSave;
        private System.Windows.Forms.Button Cancel;
    }
}