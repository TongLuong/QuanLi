﻿
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
            components = new System.ComponentModel.Container();
            MenuButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            Time = new System.Windows.Forms.Label();
            Date = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            RevenueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MenuButton
            // 
            MenuButton.AutoSize = true;
            MenuButton.BackColor = System.Drawing.Color.Transparent;
            MenuButton.BackgroundImage = Properties.Resources.Menu;
            MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            MenuButton.CausesValidation = false;
            MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuButton.ForeColor = System.Drawing.Color.Transparent;
            MenuButton.Location = new System.Drawing.Point(278, 345);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new System.Drawing.Size(158, 151);
            MenuButton.TabIndex = 0;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            MenuButton.MouseDown += MenuButton_MouseDown;
            MenuButton.MouseEnter += MenuButton_MouseEnter;
            MenuButton.MouseLeave += MenuButton_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            pictureBox1.Location = new System.Drawing.Point(-5, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(991, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.SaddleBrown;
            pictureBox3.Location = new System.Drawing.Point(-5, 519);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(991, 50);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 80.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.WindowText;
            label1.Location = new System.Drawing.Point(31, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(589, 133);
            label1.TabIndex = 4;
            label1.Text = "WELCOME";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.pngwing_com;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(659, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(208, 184);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = System.Drawing.Color.Transparent;
            Time.Font = new System.Drawing.Font(".VnLucida sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Time.Location = new System.Drawing.Point(83, 235);
            Time.Name = "Time";
            Time.Size = new System.Drawing.Size(74, 30);
            Time.TabIndex = 6;
            Time.Text = "Time";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = System.Drawing.Color.Transparent;
            Date.Font = new System.Drawing.Font(".VnLucida sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Date.Location = new System.Drawing.Point(83, 274);
            Date.Name = "Date";
            Date.Size = new System.Drawing.Size(70, 30);
            Date.TabIndex = 7;
            Date.Text = "Date";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // RevenueButton
            // 
            RevenueButton.AutoSize = true;
            RevenueButton.BackColor = System.Drawing.Color.Transparent;
            RevenueButton.BackgroundImage = Properties.Resources.Revenue;
            RevenueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            RevenueButton.CausesValidation = false;
            RevenueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            RevenueButton.FlatAppearance.BorderSize = 0;
            RevenueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RevenueButton.ForeColor = System.Drawing.Color.Transparent;
            RevenueButton.Location = new System.Drawing.Point(530, 345);
            RevenueButton.Name = "RevenueButton";
            RevenueButton.Size = new System.Drawing.Size(158, 151);
            RevenueButton.TabIndex = 8;
            RevenueButton.UseVisualStyleBackColor = false;
            RevenueButton.Click += RevenueButton_Click;
            RevenueButton.MouseDown += RevenueButton_MouseDown;
            RevenueButton.MouseEnter += RevenueButton_MouseEnter;
            RevenueButton.MouseLeave += RevenueButton_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Chocolate;
            BackgroundImage = Properties.Resources.CircleTile;
            ClientSize = new System.Drawing.Size(984, 561);
            Controls.Add(RevenueButton);
            Controls.Add(Date);
            Controls.Add(Time);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(MenuButton);
            MaximumSize = new System.Drawing.Size(1000, 600);
            MinimumSize = new System.Drawing.Size(1000, 600);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button RevenueButton;
    }
}