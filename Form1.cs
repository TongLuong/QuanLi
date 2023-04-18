using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class Form1 : Form
    {
        private Point MouseDownLocation;
        private Thread timeThread;
        private Menu menu;
        private Database database;
        private AddItem addItemForm;
        private Panel menuFood, menuDrink, menuTopping, menuSpecial, menuAll;

        public Form1()
        {
            InitializeComponent();
            menu = Menu.Instance; // singleton
            database = new Database();
            addItemForm = new AddItem();
            menuFood = menuDrink = menuTopping = menuSpecial = menuAll = null;
        }

        private void Order_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            dishes = database.ReadCSVToList<Dish>();

            foreach (Dish dish in dishes)
            {
                Label temp = new Label();
                temp.Text = dish.Name;
                temp.AutoSize = true;
                temp.Name = "";

                flowOrderName.Controls.Add(temp);
                flowOrderName.SetFlowBreak(temp, true); // set newest control as breakpoint, so that is will appear vertically in the flow panel
            }
        }

        private void AddDish_Click(object sender, EventArgs e)
        {
            addItemForm.ShowDialog();
            Dish dish = new Dish(1, addItemForm.itemName, addItemForm.itemPrice, addItemForm.itemExpense, Type.NONE, "");

            List<Dish> dishes = new List<Dish>();
            dishes.Add(dish);
            database.WriteCSV(dishes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(0, 0, 1);
            //this.TransparencyKey = Color.FromArgb(0, 0, 1);
            timeThread = new Thread(() => UpdateTime()); // create thread for updating the time
            timeThread.IsBackground = true;
            timeThread.Start();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start(); // timer1 handles effect for close button
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Start(); // timer1 handles effect for close button
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }

        private bool MouseIsOverControl(Control c)
        => c.ClientRectangle.Contains(c.PointToClient(Cursor.Position));

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(close))
            {
                close.BorderStyle = BorderStyle.None; // remove effect if mouse leave the control
                timer1.Stop();
            }
            else
                close.BorderStyle = BorderStyle.FixedSingle; // add effect if mouse leave the control
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // minimized the form
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start(); // timer2 handles effect for minimize button
        }

        private void minimize_MouseMove(object sender, MouseEventArgs e)
        {
            timer2.Start(); // timer2 handles effect for minize button
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(minimize))
            {
                minimize.BorderStyle = BorderStyle.None; // remove effect if mouse leave the control
                timer2.Stop();
            }
            else
                minimize.BorderStyle = BorderStyle.FixedSingle; // add effect if mouse is in the control
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location; // get the current location of mouse if left mouse button is pressed
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // calculate new location for the form after drag-and-drop operation
                this.Left = this.Left + (e.X - MouseDownLocation.X);
                this.Top = this.Top + (e.Y - MouseDownLocation.Y);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //timeThread.Interrupt();
        }

        private void UpdateTime()
        {
            while (true)
            {
                if (CurrTime.IsHandleCreated) // check if the control was created/existed
                {
                    CurrTime.Invoke(new Action(() =>
                    {
                        CurrTime.Text = DateTime.Now.ToString("hh:mm:ss tt ") + DateTime.Now.ToString("dd/MM/yyyy");
                    })); // method for sharing data between threads
                }
                Thread.Sleep(100);
            }
        }
        #region load menu function
        private void switchVisible(Panel temp)
        {
            if (menuFood != temp) if (menuFood != null) menuFood.Visible = false;
            if (menuDrink != temp) if (menuDrink != null) menuDrink.Visible = false;
            if (menuTopping != temp) if (menuTopping != null) menuTopping.Visible = false;
            if (menuSpecial != temp) if (menuSpecial != null) menuSpecial.Visible = false;
        }
        private Panel initPanel(Type type)
        {
            Panel temp = null;
            if (type == Type.NONE)
            {
                MessageBox.Show("Invalid Type !!");
                return null;
            }
            switch (type)
            {
                case Type.FOOD: temp = menuFood; break;
                case Type.DRINK: temp = menuDrink; break;
                case Type.TOPPING: temp = menuTopping; break;
                case Type.SPECIAL: temp = menuSpecial; break;
            }
            if (temp == null)
            {
                temp = new Panel();
                temp.Size = new Size(678, 587);
                temp.Location = new Point(111, 79);
                temp.BackColor = Color.Coral;
                temp.AutoScroll = true;
                temp.TabIndex = 44;
                Controls.Add(temp);
                temp.BringToFront();
            }
            return temp;
        }
        private void LoadMenu(Type type)
        {
            List<Dish> listByType = Menu.Instance.getListByType(type);
            Panel panelDishes = initPanel(type);
            int width = 170;
            int height = 160;
            int heightName = 50;
            int heightPrice = 25;
            int xLocation = 30;
            int yLocation = 40;
            int upDownH = 27;
            int upDownW = 45;
            int moveX = 215;
            int moveY = height + 3 + heightName + heightPrice + 20;
            int sizeList = 10;
            for (int i = 0; i < sizeList; i++)
            {
                for (int j = 0; j < 3 & i < sizeList; j++, i++)
                {
                    //init pictureBox
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(width, height);
                    pb.Location = new Point(xLocation, yLocation);
                    pb.BackColor = Color.White;

                    //init Name
                    Label lblName = new Label();
                    lblName.Size = new Size(width, heightName);
                    lblName.Location = new Point(xLocation, yLocation + pb.Size.Height);
                    lblName.AutoSize = false;
                    lblName.Text = "hahaah";
                    lblName.TextAlign = ContentAlignment.MiddleCenter;

                    //init Price
                    Label lblPrice = new Label();
                    lblPrice.Size = new Size(width, heightPrice);
                    lblPrice.Location = new Point(xLocation, lblName.Location.Y + lblName.Size.Height);
                    lblPrice.AutoSize = false;
                    lblPrice.Text = "200000";
                    lblPrice.TextAlign = ContentAlignment.MiddleCenter;

                    //init updown button
                    NumericUpDown numUpDown = new NumericUpDown();
                    numUpDown.Size = new Size(upDownW, upDownH);
                    numUpDown.Location = new Point(xLocation + width - upDownW, yLocation);
                    numUpDown.AutoSize = false;
                    numUpDown.Maximum = 99;
                    numUpDown.Minimum = 0;
                    numUpDown.Name = i.ToString();
                    numUpDown.Enabled = false;

                    //add into panel
                    panelDishes.Controls.Add(numUpDown);
                    panelDishes.Controls.Add(pb);
                    panelDishes.Controls.Add(lblName);
                    panelDishes.Controls.Add(lblPrice);
                    panelDishes.Visible = true;
                    //panelDishes.Enabled = false;
                    switchVisible(panelDishes);

                    xLocation += moveX;
                }
                i--;
                xLocation = 40;
                yLocation += moveY;
            }
        }

        #endregion

        private void Food_Click(object sender, EventArgs e)
        {
            LoadMenu(Type.FOOD);
        }

        private void Drinks_Click(object sender, EventArgs e)
        {
            LoadMenu(Type.DRINK);
        }

        private void Special_Click(object sender, EventArgs e)
        {
            LoadMenu(Type.SPECIAL);
        }

        private void Topping_Click(object sender, EventArgs e)
        {
            LoadMenu(Type.TOPPING);
        }
    }
}