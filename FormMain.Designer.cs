
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
            Form1Button = new System.Windows.Forms.Button();
            Form2Button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Form1Button
            // 
            Form1Button.Location = new System.Drawing.Point(872, 55);
            Form1Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Form1Button.Name = "Form1Button";
            Form1Button.Size = new System.Drawing.Size(107, 38);
            Form1Button.TabIndex = 0;
            Form1Button.Text = "Form 1";
            Form1Button.UseVisualStyleBackColor = true;
            Form1Button.Click += Form1Button_Click;
            Form1Button.MouseClick += Form1Button_MouseClick;
            // 
            // Form2Button
            // 
            Form2Button.Location = new System.Drawing.Point(997, 55);
            Form2Button.Name = "Form2Button";
            Form2Button.Size = new System.Drawing.Size(112, 38);
            Form2Button.TabIndex = 1;
            Form2Button.Text = "Form 2";
            Form2Button.UseVisualStyleBackColor = true;
            Form2Button.Click += Form2Button_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(Form2Button);
            Controls.Add(Form1Button);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Form1Button;
        private System.Windows.Forms.Button Form2Button;
    }
}