
namespace QuanLi
{
    partial class FormMain
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
            this.Form1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form1Button
            // 
            this.Form1Button.Location = new System.Drawing.Point(633, 33);
            this.Form1Button.Name = "Form1Button";
            this.Form1Button.Size = new System.Drawing.Size(75, 23);
            this.Form1Button.TabIndex = 0;
            this.Form1Button.Text = "Form 1";
            this.Form1Button.UseVisualStyleBackColor = true;
            this.Form1Button.Click += new System.EventHandler(this.Form1Button_Click);
            this.Form1Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1Button_MouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form1Button);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form1Button;
    }
}