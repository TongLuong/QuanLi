
namespace QuanLi
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Food = new System.Windows.Forms.Button();
            Drinks = new System.Windows.Forms.Button();
            Topping = new System.Windows.Forms.Button();
            Special = new System.Windows.Forms.Button();
            All = new System.Windows.Forms.Button();
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
            close = new System.Windows.Forms.PictureBox();
            minimize = new System.Windows.Forms.PictureBox();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            Stat = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            AddDish = new System.Windows.Forms.Button();
            CurrTime = new System.Windows.Forms.Label();
            menuFood = new System.Windows.Forms.Panel();
            FoodLabel = new System.Windows.Forms.Button();
            menuDrink = new System.Windows.Forms.Panel();
            DrinkLabel = new System.Windows.Forms.Button();
            menuTopping = new System.Windows.Forms.Panel();
            ToppingLable = new System.Windows.Forms.Button();
            menuSpecial = new System.Windows.Forms.Panel();
            SpecialLabel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuFood.SuspendLayout();
            menuDrink.SuspendLayout();
            menuTopping.SuspendLayout();
            menuSpecial.SuspendLayout();
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
            Food.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Food.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Food.Location = new System.Drawing.Point(0, 69);
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
            Drinks.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Drinks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Drinks.Location = new System.Drawing.Point(0, 109);
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
            Topping.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Topping.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Topping.Location = new System.Drawing.Point(0, 149);
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
            Special.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Special.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Special.Location = new System.Drawing.Point(0, 29);
            Special.Name = "Special";
            Special.Size = new System.Drawing.Size(90, 40);
            Special.TabIndex = 9;
            Special.Text = "Đặc biệt";
            Special.UseVisualStyleBackColor = false;
            Special.Click += Special_Click;
            // 
            // All
            // 
            All.BackColor = System.Drawing.Color.FromArgb(237, 205, 26);
            All.FlatAppearance.BorderColor = System.Drawing.Color.White;
            All.FlatAppearance.BorderSize = 0;
            All.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            All.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            All.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            All.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            All.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            All.Location = new System.Drawing.Point(0, 189);
            All.Name = "All";
            All.Size = new System.Drawing.Size(90, 38);
            All.TabIndex = 10;
            All.Text = "Tất cả";
            All.UseVisualStyleBackColor = false;
            // 
            // pbMenu
            // 
            pbMenu.BackColor = System.Drawing.Color.FromArgb(247, 23, 59);
            pbMenu.Location = new System.Drawing.Point(90, 29);
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
            label1.Location = new System.Drawing.Point(356, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 30);
            label1.TabIndex = 12;
            label1.Text = "THỰC ĐƠN";
            // 
            // pbOrder
            // 
            pbOrder.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            pbOrder.Location = new System.Drawing.Point(806, 29);
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
            Pay.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Pay.Location = new System.Drawing.Point(672, 674);
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
            label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(984, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(243, 23);
            label2.TabIndex = 24;
            label2.Text = "Danh sách các món đã đặt";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            pictureBox11.Location = new System.Drawing.Point(840, 70);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new System.Drawing.Size(536, 654);
            pictureBox11.TabIndex = 25;
            pictureBox11.TabStop = false;
            // 
            // flowOrderName
            // 
            flowOrderName.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            flowOrderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowOrderName.Location = new System.Drawing.Point(856, 116);
            flowOrderName.Name = "flowOrderName";
            flowOrderName.Size = new System.Drawing.Size(233, 587);
            flowOrderName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            label3.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(860, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 30);
            label3.TabIndex = 27;
            label3.Text = "Tên món";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            label4.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(1088, 79);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 30);
            label4.TabIndex = 28;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            label5.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(1306, 79);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 30);
            label5.TabIndex = 29;
            label5.Text = "Giá";
            // 
            // flowOrderAmount
            // 
            flowOrderAmount.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            flowOrderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowOrderAmount.Location = new System.Drawing.Point(1086, 116);
            flowOrderAmount.Name = "flowOrderAmount";
            flowOrderAmount.Size = new System.Drawing.Size(148, 587);
            flowOrderAmount.TabIndex = 27;
            // 
            // flowOrderPrice
            // 
            flowOrderPrice.BackColor = System.Drawing.Color.FromArgb(213, 255, 115);
            flowOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowOrderPrice.Location = new System.Drawing.Point(1231, 116);
            flowOrderPrice.Name = "flowOrderPrice";
            flowOrderPrice.Size = new System.Drawing.Size(129, 587);
            flowOrderPrice.TabIndex = 27;
            // 
            // close
            // 
            close.BackColor = System.Drawing.Color.Transparent;
            close.BackgroundImage = (System.Drawing.Image)resources.GetObject("close.BackgroundImage");
            close.Image = (System.Drawing.Image)resources.GetObject("close.Image");
            close.Location = new System.Drawing.Point(1371, -1);
            close.Name = "close";
            close.Size = new System.Drawing.Size(33, 30);
            close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            close.TabIndex = 35;
            close.TabStop = false;
            close.Click += close_Click;
            close.MouseMove += close_MouseMove;
            // 
            // minimize
            // 
            minimize.BackColor = System.Drawing.Color.FromArgb(0, 0, 1);
            minimize.BackgroundImage = (System.Drawing.Image)resources.GetObject("minimize.BackgroundImage");
            minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            minimize.Image = (System.Drawing.Image)resources.GetObject("minimize.Image");
            minimize.Location = new System.Drawing.Point(1338, -1);
            minimize.Name = "minimize";
            minimize.Size = new System.Drawing.Size(33, 30);
            minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            minimize.TabIndex = 36;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            minimize.MouseEnter += minimize_MouseEnter;
            minimize.MouseMove += minimize_MouseMove;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            pictureBox7.Location = new System.Drawing.Point(0, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(90, 674);
            pictureBox7.TabIndex = 37;
            pictureBox7.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
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
            Stat.Location = new System.Drawing.Point(806, -1);
            Stat.Name = "Stat";
            Stat.Size = new System.Drawing.Size(90, 30);
            Stat.TabIndex = 38;
            Stat.Text = "Thống kê";
            Stat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Stat.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(90, 5);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(146, 20);
            label6.TabIndex = 39;
            label6.Text = "Xin chào User123";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(25, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(40, 27);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // AddDish
            // 
            AddDish.BackColor = System.Drawing.Color.FromArgb(250, 248, 0);
            AddDish.FlatAppearance.BorderColor = System.Drawing.Color.White;
            AddDish.FlatAppearance.BorderSize = 0;
            AddDish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            AddDish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            AddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddDish.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddDish.Location = new System.Drawing.Point(549, 673);
            AddDish.Name = "AddDish";
            AddDish.Size = new System.Drawing.Size(117, 51);
            AddDish.TabIndex = 43;
            AddDish.Text = "Thêm món";
            AddDish.UseVisualStyleBackColor = false;
            AddDish.Click += AddDish_Click;
            // 
            // CurrTime
            // 
            CurrTime.Font = new System.Drawing.Font("Cambria", 7.20000029F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CurrTime.Location = new System.Drawing.Point(0, 704);
            CurrTime.Name = "CurrTime";
            CurrTime.Size = new System.Drawing.Size(90, 32);
            CurrTime.TabIndex = 44;
            CurrTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuFood
            // 
            menuFood.AutoScroll = true;
            menuFood.BackColor = System.Drawing.Color.Coral;
            menuFood.Controls.Add(FoodLabel);
            menuFood.Location = new System.Drawing.Point(111, 79);
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
            FoodLabel.Location = new System.Drawing.Point(3, 3);
            FoodLabel.Name = "FoodLabel";
            FoodLabel.Size = new System.Drawing.Size(90, 40);
            FoodLabel.TabIndex = 47;
            FoodLabel.Text = "Đồ ăn";
            FoodLabel.UseVisualStyleBackColor = false;
            // 
            // menuDrink
            // 
            menuDrink.AutoScroll = true;
            menuDrink.BackColor = System.Drawing.Color.Coral;
            menuDrink.Controls.Add(DrinkLabel);
            menuDrink.Location = new System.Drawing.Point(111, 79);
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
            DrinkLabel.Location = new System.Drawing.Point(3, 3);
            DrinkLabel.Name = "DrinkLabel";
            DrinkLabel.Size = new System.Drawing.Size(90, 40);
            DrinkLabel.TabIndex = 48;
            DrinkLabel.Text = "Đồ uống";
            DrinkLabel.UseVisualStyleBackColor = false;
            // 
            // menuTopping
            // 
            menuTopping.AutoScroll = true;
            menuTopping.BackColor = System.Drawing.Color.Coral;
            menuTopping.Controls.Add(ToppingLable);
            menuTopping.Location = new System.Drawing.Point(111, 79);
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
            ToppingLable.Location = new System.Drawing.Point(3, 3);
            ToppingLable.Name = "ToppingLable";
            ToppingLable.Size = new System.Drawing.Size(90, 40);
            ToppingLable.TabIndex = 49;
            ToppingLable.Text = "Topping";
            ToppingLable.UseVisualStyleBackColor = false;
            // 
            // menuSpecial
            // 
            menuSpecial.AutoScroll = true;
            menuSpecial.BackColor = System.Drawing.Color.Coral;
            menuSpecial.Controls.Add(SpecialLabel);
            menuSpecial.Location = new System.Drawing.Point(111, 79);
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
            SpecialLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            SpecialLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            SpecialLabel.Location = new System.Drawing.Point(3, 3);
            SpecialLabel.Name = "SpecialLabel";
            SpecialLabel.Size = new System.Drawing.Size(90, 40);
            SpecialLabel.TabIndex = 7;
            SpecialLabel.Text = "Đặc biệt";
            SpecialLabel.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1404, 736);
            ControlBox = false;
            Controls.Add(menuSpecial);
            Controls.Add(menuDrink);
            Controls.Add(menuTopping);
            Controls.Add(menuFood);
            Controls.Add(CurrTime);
            Controls.Add(AddDish);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(Stat);
            Controls.Add(minimize);
            Controls.Add(close);
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
            Controls.Add(All);
            Controls.Add(Special);
            Controls.Add(Topping);
            Controls.Add(Drinks);
            Controls.Add(Food);
            Controls.Add(pbMenu);
            Controls.Add(pictureBox7);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuFood.ResumeLayout(false);
            menuDrink.ResumeLayout(false);
            menuTopping.ResumeLayout(false);
            menuSpecial.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.Button Drinks;
        private System.Windows.Forms.Button Topping;
        private System.Windows.Forms.Button Special;
        private System.Windows.Forms.Button All;
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
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddDish;
        private System.Windows.Forms.Label CurrTime;
        private System.Windows.Forms.Panel menuFood;
        private System.Windows.Forms.Panel menuDrink;
        private System.Windows.Forms.Panel menuTopping;
        private System.Windows.Forms.Panel menuSpecial;
        private System.Windows.Forms.Button FoodLabel;
        private System.Windows.Forms.Button DrinkLabel;
        private System.Windows.Forms.Button ToppingLable;
        private System.Windows.Forms.Button SpecialLabel;
    }
}

