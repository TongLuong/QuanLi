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
        //private Panel menuFood, menuDrink, menuTopping, menuSpecial, menuAll;

        public Form1()
        {
            InitializeComponent();
            menu = Menu.Instance; // singleton
            database = new Database();
            addItemForm = new AddItem();
            //menuFood = menuDrink = menuTopping = menuSpecial = menuAll = null;
            LoadMenu(Type.FOOD,menuFood);
            LoadMenu(Type.DRINK,menuDrink);
            LoadMenu(Type.TOPPING,menuTopping);
            LoadMenu(Type.SPECIAL,menuSpecial);
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
                        CurrTime.Text = DateTime.Now.ToString("hh:mm:ss tt \n") + DateTime.Now.ToString("dd/MM/yyyy");
                    })); // method for sharing data between threads
                }

                Thread.Sleep(100);
            }
        }
        #region load menu function (using Builder Design Pattern)
        private interface IBuilder
        {
            //public Panel BuildPanel(Panel temp);
            public PictureBox BuildPictureBox(int w, int h, int x, int y);
            public Label BuildLabelName(int w, int h, int x, int y, string name);
            public Label BuildLabelPrice(int w, int h, int x, int y, int price);
            public NumericUpDown BuildUpDown(int w, int h, int x, int y, int id);
            public void MergeAll(Panel panelDishes, PictureBox pb, Label lblName, Label lblPrice, NumericUpDown numUpDown);
        }
        public class ConcreteBuilder : IBuilder
        {
            private static ConcreteBuilder instance;
            public static ConcreteBuilder Instance
            {
                get
                {
                    if (instance == null) instance = new ConcreteBuilder();
                    return instance;
                }
            }
            /*public Panel BuildPanel(Panel temp)
            {
                temp.Size = new Size(678, 587);
                temp.Location = new Point(111, 79);
                temp.BackColor = Color.Coral;
                temp.AutoScroll = true;
                temp.TabIndex = 44;
                //temp.BringToFront();
                return temp;
            }*/
            public PictureBox BuildPictureBox(int w, int h, int x, int y)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(w, h);
                pb.Location = new Point(x, y);
                pb.BackColor = Color.White;
                return pb;
            }
            public Label BuildLabelName(int w, int h, int x, int y, string name)
            {
                Label lblName = new Label();
                lblName.Size = new Size(w, h);
                lblName.Location = new Point(x, y);
                lblName.AutoSize = false;
                lblName.Text = name;
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                return lblName;
            }
            public Label BuildLabelPrice(int w, int h, int x, int y, int price)
            {
                Label lblPrice = new Label();
                lblPrice.Size = new Size(w, h);
                lblPrice.Location = new Point(x, y);
                lblPrice.AutoSize = false;
                lblPrice.Text = price.ToString();
                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                return lblPrice;
            }
            public NumericUpDown BuildUpDown(int w, int h, int x, int y, int i)
            {
                NumericUpDown numUpDown = new NumericUpDown();
                numUpDown.Size = new Size(w, h);
                numUpDown.Location = new Point(x, y);
                numUpDown.AutoSize = false;
                numUpDown.Maximum = 99;
                numUpDown.Minimum = 0;
                numUpDown.Name = i.ToString();
                numUpDown.Enabled = false;
                return numUpDown;
            }
            public void MergeAll(Panel panelDishes, PictureBox pb, Label lblName, Label lblPrice, NumericUpDown numUpDown)
            {
                panelDishes.Controls.Add(numUpDown);
                panelDishes.Controls.Add(pb);
                panelDishes.Controls.Add(lblName);
                panelDishes.Controls.Add(lblPrice);
                panelDishes.Visible = false;
                //panelDishes.Enabled = false;
            }
        }
        private void switchVisible(Panel temp)
        {
            if (menuFood != temp) if (menuFood != null) menuFood.Visible = false;
            if (menuDrink != temp) if (menuDrink != null) menuDrink.Visible = false;
            if (menuTopping != temp) if (menuTopping != null) menuTopping.Visible = false;
            if (menuSpecial != temp) if (menuSpecial != null) menuSpecial.Visible = false;
            temp.Visible = true;
        }
        /*private Panel GetPanelByType(Type type)
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
            return temp;
        }*/
        private void LoadMenu(Type type,Panel panelDishes)
        {
            //init value for scale
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

            //Build Panel
            List<Dish> listByType = Menu.Instance.getListByType(type);
            //Panel panelDishes = GetPanelByType(type);
            //panelDishes = ConcreteBuilder.Instance.BuildPanel(panelDishes);

            for (int i = 0; i < sizeList; i++)
            {
                for (int j = 0; j < 3 & i < sizeList; j++, i++)
                {
                    //Build pictureBox
                    PictureBox pb = ConcreteBuilder.Instance.BuildPictureBox(width, height, xLocation, yLocation);

                    //Build Label Name
                    Label lblName = ConcreteBuilder.Instance.BuildLabelName(width, heightName, xLocation, yLocation + pb.Size.Height, "hahahaha");

                    //Build Price
                    Label lblPrice = ConcreteBuilder.Instance.BuildLabelPrice(width, heightPrice, xLocation, lblName.Location.Y + lblName.Size.Height, 200000);

                    //Build updown button
                    NumericUpDown numUpDown = ConcreteBuilder.Instance.BuildUpDown(upDownW, upDownH, xLocation + width - upDownW, yLocation, i);

                    //add into panel
                    ConcreteBuilder.Instance.MergeAll(panelDishes, pb, lblName, lblPrice, numUpDown);
                    
                    xLocation += moveX;
                }
                i--;
                xLocation = 30;
                yLocation += moveY;
            }
            //switchVisible(panelDishes);
        }

        #endregion

        private void Food_Click(object sender, EventArgs e)
        {
            //LoadMenu(Type.FOOD);
            //menuFood.Visible = true;
            switchVisible(menuFood);
        }

        private void Drinks_Click(object sender, EventArgs e)
        {
            //LoadMenu(Type.DRINK);
            switchVisible(menuDrink);
            //menuDrink.Visible = true;
        }

        private void Special_Click(object sender, EventArgs e)
        {
            //LoadMenu(Type.SPECIAL);
           switchVisible(menuSpecial);
            //menuSpecial.Visible = true;
        }

        private void Topping_Click(object sender, EventArgs e)
        {
            //LoadMenu(Type.TOPPING);
            switchVisible(menuTopping);
            //menuTopping.Visible = true; 
        }
    }
}