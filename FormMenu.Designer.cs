
namespace QuanLi
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            Food = new System.Windows.Forms.Button();
            Drinks = new System.Windows.Forms.Button();
            Topping = new System.Windows.Forms.Button();
            Special = new System.Windows.Forms.Button();
            pbMenu = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pbOrder = new System.Windows.Forms.PictureBox();
            Pay = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            pictureBox11 = new System.Windows.Forms.PictureBox();
            flowOrderName = new System.Windows.Forms.FlowLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            flowOrderAmount = new System.Windows.Forms.FlowLayoutPanel();
            flowOrderPrice = new System.Windows.Forms.FlowLayoutPanel();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            Stat = new System.Windows.Forms.Button();
            WelcomeLabel = new System.Windows.Forms.Label();
            AddDish = new System.Windows.Forms.Button();
            menuFood = new CustomPanel();
            FoodLabel = new System.Windows.Forms.Button();
            menuDrink = new CustomPanel();
            DrinkLabel = new System.Windows.Forms.Button();
            menuTopping = new CustomPanel();
            ToppingLable = new System.Windows.Forms.Button();
            menuSpecial = new CustomPanel();
            SpecialLabel = new System.Windows.Forms.Button();
            Total = new System.Windows.Forms.Label();
            TotalPrice = new System.Windows.Forms.Label();
            RefreshBut = new System.Windows.Forms.Button();
            deleteDish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // Food
            // 
            Food.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            Food.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Food.FlatAppearance.BorderSize = 0;
            Food.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Food.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Food.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Food.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Food.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Food.Location = new System.Drawing.Point(0, 59);
            Food.Name = "Food";
            Food.Size = new System.Drawing.Size(90, 40);
            Food.TabIndex = 6;
            Food.Text = "Đồ ăn";
            Food.UseVisualStyleBackColor = false;
            Food.Click += Food_Click;
            // 
            // Drinks
            // 
            Drinks.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            Drinks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Drinks.FlatAppearance.BorderSize = 0;
            Drinks.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Drinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Drinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Drinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Drinks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Drinks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Drinks.Location = new System.Drawing.Point(0, 99);
            Drinks.Name = "Drinks";
            Drinks.Size = new System.Drawing.Size(90, 40);
            Drinks.TabIndex = 7;
            Drinks.Text = "Đồ uống";
            Drinks.UseVisualStyleBackColor = false;
            Drinks.Click += Drinks_Click;
            // 
            // Topping
            // 
            Topping.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            Topping.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Topping.FlatAppearance.BorderSize = 0;
            Topping.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Topping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Topping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Topping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Topping.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Topping.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Topping.Location = new System.Drawing.Point(0, 139);
            Topping.Name = "Topping";
            Topping.Size = new System.Drawing.Size(90, 40);
            Topping.TabIndex = 8;
            Topping.Text = "Topping";
            Topping.UseVisualStyleBackColor = false;
            Topping.Click += Topping_Click;
            // 
            // Special
            // 
            Special.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            Special.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Special.FlatAppearance.BorderSize = 0;
            Special.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Special.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Special.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Special.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Special.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Special.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Special.Location = new System.Drawing.Point(0, 19);
            Special.Name = "Special";
            Special.Size = new System.Drawing.Size(90, 40);
            Special.TabIndex = 9;
            Special.Text = "Đặc biệt";
            Special.UseVisualStyleBackColor = false;
            Special.Click += Special_Click;
            // 
            // pbMenu
            // 
            pbMenu.BackColor = System.Drawing.Color.FromArgb(247, 23, 59);
            pbMenu.Location = new System.Drawing.Point(90, 19);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new System.Drawing.Size(718, 707);
            pbMenu.TabIndex = 11;
            pbMenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(247, 23, 59);
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(372, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 30);
            label1.TabIndex = 12;
            label1.Text = "THỰC ĐƠN";
            // 
            // pbOrder
            // 
            pbOrder.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            pbOrder.Location = new System.Drawing.Point(806, 19);
            pbOrder.Name = "pbOrder";
            pbOrder.Size = new System.Drawing.Size(598, 707);
            pbOrder.TabIndex = 13;
            pbOrder.TabStop = false;
            // 
            // Pay
            // 
            Pay.BackColor = System.Drawing.Color.FromArgb(250, 248, 0);
            Pay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Pay.FlatAppearance.BorderSize = 0;
            Pay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Pay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Pay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Pay.Location = new System.Drawing.Point(672, 664);
            Pay.Name = "Pay";
            Pay.Size = new System.Drawing.Size(117, 51);
            Pay.TabIndex = 23;
            Pay.Text = "Thanh toán";
            Pay.UseVisualStyleBackColor = false;
            Pay.Click += Pay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(984, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(263, 28);
            label2.TabIndex = 24;
            label2.Text = "Danh sách các món đã đặt";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            pictureBox11.Location = new System.Drawing.Point(840, 60);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new System.Drawing.Size(536, 654);
            pictureBox11.TabIndex = 25;
            pictureBox11.TabStop = false;
            // 
            // flowOrderName
            // 
            flowOrderName.AutoScroll = true;
            flowOrderName.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            flowOrderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowOrderName.Location = new System.Drawing.Point(856, 106);
            flowOrderName.Name = "flowOrderName";
            flowOrderName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            flowOrderName.Size = new System.Drawing.Size(233, 546);
            flowOrderName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(860, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 35);
            label3.TabIndex = 27;
            label3.Text = "Tên món";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(1088, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 35);
            label4.TabIndex = 28;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(1306, 69);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 35);
            label5.TabIndex = 29;
            label5.Text = "Giá";
            // 
            // flowOrderAmount
            // 
            flowOrderAmount.AutoScroll = true;
            flowOrderAmount.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            flowOrderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowOrderAmount.Location = new System.Drawing.Point(1086, 106);
            flowOrderAmount.Name = "flowOrderAmount";
            flowOrderAmount.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            flowOrderAmount.Size = new System.Drawing.Size(148, 546);
            flowOrderAmount.TabIndex = 27;
            // 
            // flowOrderPrice
            // 
            flowOrderPrice.AutoScroll = true;
            flowOrderPrice.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            flowOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowOrderPrice.Location = new System.Drawing.Point(1231, 106);
            flowOrderPrice.Name = "flowOrderPrice";
            flowOrderPrice.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            flowOrderPrice.Size = new System.Drawing.Size(129, 546);
            flowOrderPrice.TabIndex = 27;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            pictureBox7.Location = new System.Drawing.Point(0, 19);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(90, 707);
            pictureBox7.TabIndex = 37;
            pictureBox7.TabStop = false;
            // 
            // Stat
            // 
            Stat.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            Stat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Stat.FlatAppearance.BorderSize = 0;
            Stat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Stat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            Stat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Stat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Stat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Stat.Location = new System.Drawing.Point(840, 19);
            Stat.Name = "Stat";
            Stat.Size = new System.Drawing.Size(90, 30);
            Stat.TabIndex = 38;
            Stat.Text = "Thống kê";
            Stat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Stat.UseVisualStyleBackColor = false;
            Stat.Click += Stat_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BackColor = System.Drawing.Color.White;
            WelcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            WelcomeLabel.ForeColor = System.Drawing.Color.Black;
            WelcomeLabel.Location = new System.Drawing.Point(0, -1);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new System.Drawing.Size(56, 20);
            WelcomeLabel.TabIndex = 39;
            WelcomeLabel.Text = "Chào...";
            // 
            // AddDish
            // 
            AddDish.BackColor = System.Drawing.Color.FromArgb(250, 248, 0);
            AddDish.FlatAppearance.BorderColor = System.Drawing.Color.White;
            AddDish.FlatAppearance.BorderSize = 0;
            AddDish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            AddDish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            AddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddDish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddDish.Location = new System.Drawing.Point(260, 664);
            AddDish.Name = "AddDish";
            AddDish.Size = new System.Drawing.Size(117, 51);
            AddDish.TabIndex = 43;
            AddDish.Text = "Thêm món";
            AddDish.UseVisualStyleBackColor = false;
            AddDish.Click += AddDish_Click;
            // 
            // menuFood
            // 
            menuFood.AutoScroll = true;
            menuFood.BackColor = System.Drawing.Color.Coral;
            menuFood.Location = new System.Drawing.Point(111, 69);
            menuFood.Name = "menuFood";
            menuFood.Size = new System.Drawing.Size(678, 587);
            menuFood.TabIndex = 45;
            // 
            // FoodLabel
            // 
            FoodLabel.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            FoodLabel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            FoodLabel.FlatAppearance.BorderSize = 0;
            FoodLabel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            FoodLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            FoodLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            FoodLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FoodLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FoodLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FoodLabel.Location = new System.Drawing.Point(111, 26);
            FoodLabel.Name = "FoodLabel";
            FoodLabel.Size = new System.Drawing.Size(90, 40);
            FoodLabel.TabIndex = 47;
            FoodLabel.Text = "Đồ ăn";
            FoodLabel.UseVisualStyleBackColor = false;
            FoodLabel.Visible = false;
            // 
            // menuDrink
            // 
            menuDrink.AutoScroll = true;
            menuDrink.BackColor = System.Drawing.Color.Coral;
            menuDrink.Location = new System.Drawing.Point(111, 69);
            menuDrink.Name = "menuDrink";
            menuDrink.Size = new System.Drawing.Size(678, 587);
            menuDrink.TabIndex = 46;
            // 
            // DrinkLabel
            // 
            DrinkLabel.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            DrinkLabel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            DrinkLabel.FlatAppearance.BorderSize = 0;
            DrinkLabel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            DrinkLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            DrinkLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            DrinkLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DrinkLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DrinkLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            DrinkLabel.Location = new System.Drawing.Point(111, 26);
            DrinkLabel.Name = "DrinkLabel";
            DrinkLabel.Size = new System.Drawing.Size(90, 40);
            DrinkLabel.TabIndex = 48;
            DrinkLabel.Text = "Đồ uống";
            DrinkLabel.UseVisualStyleBackColor = false;
            DrinkLabel.Visible = false;
            // 
            // menuTopping
            // 
            menuTopping.AutoScroll = true;
            menuTopping.BackColor = System.Drawing.Color.Coral;
            menuTopping.Location = new System.Drawing.Point(111, 69);
            menuTopping.Name = "menuTopping";
            menuTopping.Size = new System.Drawing.Size(678, 587);
            menuTopping.TabIndex = 47;
            // 
            // ToppingLable
            // 
            ToppingLable.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            ToppingLable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            ToppingLable.FlatAppearance.BorderSize = 0;
            ToppingLable.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            ToppingLable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            ToppingLable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            ToppingLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ToppingLable.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ToppingLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            ToppingLable.Location = new System.Drawing.Point(111, 26);
            ToppingLable.Name = "ToppingLable";
            ToppingLable.Size = new System.Drawing.Size(90, 40);
            ToppingLable.TabIndex = 49;
            ToppingLable.Text = "Topping";
            ToppingLable.UseVisualStyleBackColor = false;
            ToppingLable.Visible = false;
            // 
            // menuSpecial
            // 
            menuSpecial.AutoScroll = true;
            menuSpecial.BackColor = System.Drawing.Color.Coral;
            menuSpecial.Location = new System.Drawing.Point(111, 69);
            menuSpecial.Name = "menuSpecial";
            menuSpecial.Size = new System.Drawing.Size(678, 587);
            menuSpecial.TabIndex = 48;
            // 
            // SpecialLabel
            // 
            SpecialLabel.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            SpecialLabel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            SpecialLabel.FlatAppearance.BorderSize = 0;
            SpecialLabel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            SpecialLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            SpecialLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            SpecialLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SpecialLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            SpecialLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            SpecialLabel.Location = new System.Drawing.Point(111, 26);
            SpecialLabel.Name = "SpecialLabel";
            SpecialLabel.Size = new System.Drawing.Size(90, 40);
            SpecialLabel.TabIndex = 7;
            SpecialLabel.Text = "Đặc biệt";
            SpecialLabel.UseVisualStyleBackColor = false;
            SpecialLabel.Visible = false;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            Total.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Total.Location = new System.Drawing.Point(856, 663);
            Total.Name = "Total";
            Total.Size = new System.Drawing.Size(203, 41);
            Total.TabIndex = 49;
            Total.Text = "THÀNH TIỀN";
            // 
            // TotalPrice
            // 
            TotalPrice.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            TotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TotalPrice.Location = new System.Drawing.Point(1065, 663);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TotalPrice.Size = new System.Drawing.Size(295, 41);
            TotalPrice.TabIndex = 50;
            TotalPrice.Text = "0";
            TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RefreshBut
            // 
            RefreshBut.BackColor = System.Drawing.Color.FromArgb(250, 248, 0);
            RefreshBut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            RefreshBut.FlatAppearance.BorderSize = 0;
            RefreshBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            RefreshBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            RefreshBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RefreshBut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            RefreshBut.Location = new System.Drawing.Point(534, 664);
            RefreshBut.Name = "RefreshBut";
            RefreshBut.Size = new System.Drawing.Size(117, 51);
            RefreshBut.TabIndex = 51;
            RefreshBut.Text = "Làm Mới";
            RefreshBut.UseVisualStyleBackColor = false;
            RefreshBut.Click += RefreshBut_Click;
            // 
            // deleteDish
            // 
            deleteDish.BackColor = System.Drawing.Color.FromArgb(250, 248, 0);
            deleteDish.FlatAppearance.BorderColor = System.Drawing.Color.White;
            deleteDish.FlatAppearance.BorderSize = 0;
            deleteDish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            deleteDish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            deleteDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteDish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteDish.Location = new System.Drawing.Point(397, 664);
            deleteDish.Name = "deleteDish";
            deleteDish.Size = new System.Drawing.Size(117, 51);
            deleteDish.TabIndex = 52;
            deleteDish.Text = "Xóa món";
            deleteDish.UseVisualStyleBackColor = false;
            deleteDish.Click += deleteDish_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1404, 726);
            Controls.Add(menuSpecial);
            Controls.Add(menuDrink);
            Controls.Add(menuTopping);
            Controls.Add(FoodLabel);
            Controls.Add(ToppingLable);
            Controls.Add(DrinkLabel);
            Controls.Add(SpecialLabel);
            Controls.Add(deleteDish);
            Controls.Add(WelcomeLabel);
            Controls.Add(RefreshBut);
            Controls.Add(Stat);
            Controls.Add(TotalPrice);
            Controls.Add(Total);
            Controls.Add(menuFood);
            Controls.Add(AddDish);
            Controls.Add(flowOrderPrice);
            Controls.Add(flowOrderAmount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flowOrderName);
            Controls.Add(pictureBox11);
            Controls.Add(label2);
            Controls.Add(Pay);
            Controls.Add(label1);
            Controls.Add(pbOrder);
            Controls.Add(Special);
            Controls.Add(Topping);
            Controls.Add(Drinks);
            Controls.Add(Food);
            Controls.Add(pbMenu);
            Controls.Add(pictureBox7);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Thực đơn";
            FormClosing += FormMenu_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.Button Drinks;
        private System.Windows.Forms.Button Topping;
        private System.Windows.Forms.Button Special;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOrder;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.FlowLayoutPanel flowOrderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowOrderAmount;
        private System.Windows.Forms.FlowLayoutPanel flowOrderPrice;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button AddDish;
        private System.Windows.Forms.Button FoodLabel;
        private System.Windows.Forms.Button DrinkLabel;
        private System.Windows.Forms.Button ToppingLable;
        private System.Windows.Forms.Button SpecialLabel;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button RefreshBut;
        private System.Windows.Forms.Button deleteDish;
        private CustomPanel menuFood;
        private CustomPanel menuDrink;
        private CustomPanel menuTopping;
        private CustomPanel menuSpecial;
    }
}

