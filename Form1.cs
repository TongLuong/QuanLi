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
        private static Form1 instance;
        private Point MouseDownLocation;
        private Thread timeThread;
        private Database database;
        private AddItem addItemForm;

        private Form1()
        {
            InitializeComponent();
            database = Database.Instance;
            addItemForm = new AddItem();
            LoadMenu(Type.FOOD, menuFood);
            LoadMenu(Type.DRINK, menuDrink);
            LoadMenu(Type.TOPPING, menuTopping);
            LoadMenu(Type.SPECIAL, menuSpecial);
        }

        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }
        }
        private void AddDish_Click(object sender, EventArgs e)
        {
            addItemForm.ShowDialog();
            if (addItemForm.Abort)
                return;
            Dish dish = new Dish(addItemForm.itemName, addItemForm.itemPrice, addItemForm.itemExpense, addItemForm.itemType, "");

            List<Dish> dishes = new List<Dish>();
            dishes.Add(dish);
            database.WriteCSV(dishes);
            Menu.Instance.AddDish(dish);
            ReLoadMenu(dish.Type);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            
        }

        private void UpdateTime()
        {
            while (true)
            {
                try
                {
                    if (CurrTime.IsHandleCreated) // check if the control was created/existed
                    {
                        CurrTime.Invoke(new Action(() =>
                        {
                            CurrTime.Text = DateTime.Now.ToString("hh:mm:ss tt \n") + DateTime.Now.ToString("dd/MM/yyyy");
                        })); // method for sharing data between threads
                    }
                }
                catch
                {
                    return;
                }

                Thread.Sleep(100);
            }
        }

        #region Build custom controls and Mediator
        public interface IMediator
        {
            void Notify(object sender, string mes);

            List<Control> GetControls();
        }
        public class ConcreteMediator : IMediator
        {
            private CustomNumericUpDown num;
            private CustomLabel name;
            private CustomLabel amount;
            private CustomLabel price;

            public ConcreteMediator(CustomNumericUpDown num, CustomLabel name, CustomLabel amount, CustomLabel price)
            {
                this.num = num;
                this.num.Mediator = this;

                this.name = name;
                this.name.Mediator = this;

                this.amount = amount;
                this.amount.Mediator = this;

                this.price = price;
                this.price.Mediator = this;
            }

            public void Notify(object sender, string mes)
            {
                // mes: contains amount
                if (sender.GetType() == typeof(CustomNumericUpDown))
                {
                    this.amount.ChangeText(mes);
                    double newPrice = Convert.ToDouble(this.price.BasePrice) * Convert.ToDouble(mes);
                    this.price.ChangeText(newPrice.ToString());
                }
            }

            public List<Control> GetControls()
            {
                return new List<Control>() { name, amount, price };
            }
        }
        //CustomeUpDown has medidator and currDish
        public partial class CustomNumericUpDown : NumericUpDown
        {
            private bool hasMediator;
            public bool HasMediator
            {
                get => hasMediator;
                set => hasMediator = value;
            }

            private IMediator mediator; // instance stores ConcreteMediator
            public IMediator Mediator
            {
                get => mediator;
                set => mediator = value;
            }

            private Dish currDish;
            public Dish CurrDish
            {
                get => currDish;
                set => currDish = value;
            }
            //======================================
            public CustomNumericUpDown() : base()
            {
                hasMediator = false;
                mediator = null;
            }

            public void AttachDish(Dish dish)
            {
                currDish = dish;
            }

            public void ChangeValue()
            {
                mediator.Notify(this, this.Value.ToString());
            }
        }
        public partial class CustomLabel : Label
        {
            private IMediator mediator;  // instance stores ConcreteMediator
            public IMediator Mediator
            {
                get => mediator;
                set => mediator = value;
            }

            private double basePrice;
            public double BasePrice
            {
                get => basePrice;
                set => basePrice = value;
            }
            //======================================
            public CustomLabel(double basePrice = -1) : base()
            {
                this.basePrice = basePrice;
                mediator = null;
            }

            public void ChangeText(string newText)
            {
                this.Text = newText;
            }
        }
        #endregion

        #region load menu function (using Builder Design Pattern)
        private interface IBuilder
        {
            public PictureBox BuildPictureBox(int w, int h, int x, int y);
            public Label BuildLabelName(int w, int h, int x, int y, string name);
            public Label BuildLabelPrice(int w, int h, int x, int y, double price);
            public CustomNumericUpDown BuildUpDown(int w, int h, int x, int y, int id, Dish dish);
            public void MergeAll(Panel panelDishes, PictureBox pb, Label lblName, Label lblPrice, CustomNumericUpDown numUpDown);
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

            public PictureBox BuildPictureBox(int w, int h, int x, int y)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(w, h);
                pb.Location = new Point(x, y);
                pb.BackColor = Color.White;
                pb.Image = pb.InitialImage;
                //pb.Image = Image.FromFile(dish.PathImage); // commented until we have images
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
            public Label BuildLabelPrice(int w, int h, int x, int y, double price)
            {
                Label lblPrice = new Label();
                lblPrice.Size = new Size(w, h);
                lblPrice.Location = new Point(x, y);
                lblPrice.AutoSize = false;
                lblPrice.Text = price.ToString();
                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                return lblPrice;
            }
            public CustomNumericUpDown BuildUpDown(int w, int h, int x, int y, int i, Dish dish)
            {
                CustomNumericUpDown numUpDown = new CustomNumericUpDown();
                numUpDown.Size = new Size(w, h);
                numUpDown.Location = new Point(x, y);
                numUpDown.AutoSize = false;
                numUpDown.Maximum = 99;
                numUpDown.Minimum = 0;
                numUpDown.Name = i.ToString();
                numUpDown.Enabled = true;
                numUpDown.ValueChanged += NumUpDown_ValueChanged;
                numUpDown.AttachDish(dish);
                return numUpDown;
            }

            private void NumUpDown_ValueChanged(object sender, EventArgs e)
            {
                CustomNumericUpDown cnup = (CustomNumericUpDown)sender;
                if (cnup == null || cnup.CurrDish.Equals(null))
                    return;

                Form1 form1 = Form1.Instance;
                if (cnup.Value <= 0)
                {
                    List<Control> controls = cnup.Mediator.GetControls();
                    form1.flowOrderName.Controls.Remove(controls[0]);
                    form1.flowOrderAmount.Controls.Remove(controls[1]);
                    form1.flowOrderPrice.Controls.Remove(controls[2]);
                    cnup.HasMediator = false;
                    Form1.Instance.CalToTal();
                    return;
                }

                if (cnup.HasMediator) // if this object has initialized mediator already
                {
                    cnup.ChangeValue(); // then we just change the current text
                    Form1.Instance.CalToTal();
                    return;
                }

                Dish dish = cnup.CurrDish;

                // add name
                CustomLabel name = new CustomLabel();
                name.Text = dish.Name;
                name.AutoSize = true;
                name.Name = dish.ID.ToString() + ",Name";
                form1.flowOrderName.Controls.Add(name);
                // set newest control as breakpoint, so that is will appear vertically in the flow panel
                form1.flowOrderName.SetFlowBreak(name, true);

                // add amount
                CustomLabel amount = new CustomLabel();
                amount.Text = ((int)cnup.Value).ToString();
                amount.AutoSize = true;
                amount.Name = dish.ID.ToString() + ",Amount";
                form1.flowOrderAmount.Controls.Add(amount);
                // set newest control as breakpoint, so that is will appear vertically in the flow panel
                form1.flowOrderAmount.SetFlowBreak(amount, true);

                // add price
                CustomLabel price = new CustomLabel();
                price.BasePrice = dish.Price; // set base price
                price.Text = (dish.Price * (double)cnup.Value).ToString();
                price.AutoSize = true;
                price.Name = dish.ID.ToString() + ",Price";
                form1.flowOrderPrice.Controls.Add(price);
                // set newest control as breakpoint, so that is will appear vertically in the flow panel
                form1.flowOrderPrice.SetFlowBreak(price, true);

                // init mediator
                new ConcreteMediator(cnup, name, amount, price);
                cnup.HasMediator = true;
                Form1.Instance.CalToTal();
            }
            public void MergeAll(Panel panelDishes, PictureBox pb, Label lblName, Label lblPrice, CustomNumericUpDown numUpDown)
            {
                panelDishes.Controls.Add(numUpDown);
                panelDishes.Controls.Add(pb);
                //pb.Controls.Add(numUpDown);
                panelDishes.Controls.Add(lblName);
                panelDishes.Controls.Add(lblPrice);
                panelDishes.Visible = false;
                //panelDishes.Enabled = false;
            }
        }
        private void switchVisible(Panel temp)
        {
            temp.Visible = true;
            temp.BringToFront();
            if (menuFood != temp) if (menuFood != null) menuFood.Visible = false;
            if (menuDrink != temp) if (menuDrink != null) menuDrink.Visible = false;
            if (menuTopping != temp) if (menuTopping != null) menuTopping.Visible = false;
            if (menuSpecial != temp) if (menuSpecial != null) menuSpecial.Visible = false;
        }
        private void LoadMenu(Type type, Panel panelDishes)
        {
            //init value for scale
            int width = 170;
            int height = 160;
            int heightName = 50;
            int heightPrice = 25;
            int xLocation = 30;
            int yLocation = 50;
            int upDownH = 27;
            int upDownW = 45;
            int moveX = 215;
            int moveY = height + 3 + heightName + heightPrice + 20;
            List<Dish> dish = Menu.Instance.getListByType(type);
            IEnumerator<Dish> iterDish = dish.GetEnumerator();
            int sizeList = dish.Count;

            //Build Panel
            List<Dish> listByType = Menu.Instance.getListByType(type);

            for (int i = 0; i < sizeList; i++)
            {
                for (int j = 0; j < 3 && i < sizeList && iterDish.MoveNext(); j++, i++)
                {
                    //Build pictureBox
                    PictureBox pb = ConcreteBuilder.Instance.BuildPictureBox(width, height, xLocation, yLocation);

                    //Build Label Name
                    Label lblName = ConcreteBuilder.Instance.BuildLabelName(width, heightName, xLocation, yLocation + pb.Size.Height, iterDish.Current.Name);

                    //Build Price
                    Label lblPrice = ConcreteBuilder.Instance.BuildLabelPrice(width, heightPrice, xLocation, lblName.Location.Y + lblName.Size.Height, iterDish.Current.Price);

                    //Build updown button
                    CustomNumericUpDown numUpDown = ConcreteBuilder.Instance.BuildUpDown(upDownW, upDownH, xLocation + width - upDownW, yLocation, i, iterDish.Current);

                    //add into panel
                    ConcreteBuilder.Instance.MergeAll(panelDishes, pb, lblName, lblPrice, numUpDown);

                    xLocation += moveX;
                }
                i--;
                xLocation = 30;
                yLocation += moveY;
            }
        }
        private void ReLoadMenu(Type type) // used after remove or add dish to display on form
        {
            Panel panelDishes = null;
            switch (type)
            {
                case Type.FOOD: panelDishes = menuFood; break;
                case Type.DRINK: panelDishes = menuDrink; break;
                case Type.TOPPING: panelDishes = menuTopping; break;
                case Type.SPECIAL: panelDishes = menuSpecial; break;
            }
            panelDishes.Controls.Clear();
            LoadMenu(type, panelDishes);
        }
        #endregion

        private void Food_Click(object sender, EventArgs e)
        {
            switchVisible(menuFood);
        }

        private void Drinks_Click(object sender, EventArgs e)
        {
            switchVisible(menuDrink);
        }

        private void Special_Click(object sender, EventArgs e)
        {
            switchVisible(menuSpecial);
        }

        private void Topping_Click(object sender, EventArgs e)
        {
            switchVisible(menuTopping);
        }

        #region Save to Menu and Bill
        private void Refresh_Click(object sender, EventArgs e)
        {
            if (TotalPrice.Text == "0")
            {
                return;
            }
            foreach (Control control in menuFood.Controls)
            {
                if (control is CustomNumericUpDown)
                {
                    CustomNumericUpDown upDown = (CustomNumericUpDown)control;
                    upDown.Value = 0;
                }
            }

            foreach (Control control in menuDrink.Controls)
            {
                if (control is CustomNumericUpDown)
                {
                    CustomNumericUpDown upDown = (CustomNumericUpDown)control;
                    upDown.Value = 0;
                }
            }

            foreach (Control control in menuTopping.Controls)
            {
                if (control is CustomNumericUpDown)
                {
                    CustomNumericUpDown upDown = (CustomNumericUpDown)control;
                    upDown.Value = 0;
                }
            }

            foreach (Control control in menuSpecial.Controls)
            {
                if (control is CustomNumericUpDown)
                {
                    CustomNumericUpDown upDown = (CustomNumericUpDown)control;
                    upDown.Value = 0;
                }
            }

        }
        private void UpdateNRefresh(Control control)
        {
            if (control is CustomNumericUpDown)
            {
                CustomNumericUpDown upDown = (CustomNumericUpDown)control;
                if (upDown.Value != 0)
                {
                    upDown.CurrDish.NumberOfSells += Convert.ToInt32(upDown.Value);
                    upDown.Value = 0;

                }
            }
        }
        private void Pay_Click(object sender, EventArgs e)
        {
            //Save Bill
            if (Convert.ToDouble(TotalPrice.Text) == 0)
            {
                MessageBox.Show("Unavailable Bill !!");
                return;
            }
            Bill newBill = new Bill();
            newBill.ModifyBill(flowOrderName, flowOrderAmount, flowOrderPrice);
            ListBill.Instance.Bills.Add(newBill);


            //Update on Menu and refresh
            foreach (Control control in menuFood.Controls)
            {
                UpdateNRefresh(control);
            }

            foreach (Control control in menuDrink.Controls)
            {
                UpdateNRefresh(control);
            }

            foreach (Control control in menuTopping.Controls)
            {
                UpdateNRefresh(control);
            }

            foreach (Control control in menuSpecial.Controls)
            {
                UpdateNRefresh(control);
            }

        }
        #endregion

        public void CalToTal()
        {
            double total = 0;
            List<Control> price = flowOrderPrice.Controls.OfType<Control>().ToList();
            int size = price.Count;
            for (int i = 0; i < size; i++)
            {
                double newPrice = Convert.ToDouble(price[i].Text);
                total += newPrice;
            }
            TotalPrice.Text = Convert.ToString(total);
        }
    }
}