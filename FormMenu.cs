﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class FormMenu : Form
    {
        private static FormMenu instance;
        private Thread timeThread;
        private Database database;
        private AddItem addItemForm;
        private DeleteItem deleteItemForm;
        private Caretaker caretaker;

        private FormMenu()
        {
            InitializeComponent();
            database = Database.Instance;
            addItemForm = new AddItem();
            caretaker = new Caretaker(this);
            deleteItemForm = new DeleteItem();

            // declaration bellow
            keyHandler = new KeyHandler(Keys.Z, this);
            keyHandler.Register();

            LoadMenu(Type.FOOD, menuFood);
            LoadMenu(Type.DRINK, menuDrink);
            LoadMenu(Type.TOPPING, menuTopping);
            LoadMenu(Type.SPECIAL, menuSpecial);
        }

        public static FormMenu Instance
        {
            get
            {
                if (instance == null)
                    instance = new FormMenu();
                return instance;
            }
        }

        #region add and delete button
        private void AddDish_Click(object sender, EventArgs e)
        {
            if (flowOrderName.Controls.Count > 0)
            {
                MessageBox.Show("Đang đặt đơn hàng, không thể thêm món !", "Lỗi");
                return;
            }
            addItemForm.ShowDialog();
            if (addItemForm.Abort)
                return;

            Dish dish = new Dish(addItemForm.ItemName, addItemForm.ItemPrice, addItemForm.ItemExpense, addItemForm.ItemType, addItemForm.ImageName);
            if (!Menu.Instance.AddDish(dish))
            {
                return;
            }
            addItemForm.AddImage();
            List<Dish> dishes = new List<Dish>();
            dishes.Add(dish);
            database.WriteCSV(dishes);
            ReLoadMenu(dish.Type);
            MessageBox.Show("Thêm món thành công !", "Thông báo");
        }

        private void deleteDish_Click(object sender, EventArgs e)
        {
            if (flowOrderName.Controls.Count > 0)
            {
                MessageBox.Show("Đang đặt đơn hàng, không thể xóa món !", "Lỗi");
                return;
            }
            deleteItemForm.ShowMenu();
            deleteItemForm.ShowDialog();
            if (deleteItemForm.Abort) return;
            MessageBox.Show("Đã xóa món thành công !", "Thông báo");
        }
        #endregion

        #region Events Handling
        private void Form1_Load(object sender, EventArgs e)
        {
            timeThread = new Thread(() => UpdateTime()); // create thread for updating the time
            timeThread.IsBackground = true;
            timeThread.Start();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            FormStatistics form2 = new FormStatistics();
            form2.Show();
        }

        public void ApplicationClosing(ref FormClosingEventArgs e)
        {
            ExittingForm ef = new ExittingForm();
            ef.ShowDialog();

            switch (ef.Result)
            {
                case ExittingForm.CustomDialogResult.SAVE:
                    Menu menu = Menu.Instance;

                    List<Dish> result = new List<Dish>();
                    foreach (CustomNumericUpDown control in menuFood.Controls.OfType<CustomNumericUpDown>())
                    {
                        if (control.CurrDish.NumberOfSells > 0)
                            result.Add(control.CurrDish);
                    }

                    foreach (CustomNumericUpDown control in menuDrink.Controls.OfType<CustomNumericUpDown>())
                    {
                        if (control.CurrDish.NumberOfSells > 0)
                            result.Add(control.CurrDish);
                    }

                    foreach (CustomNumericUpDown control in menuTopping.Controls.OfType<CustomNumericUpDown>())
                    {
                        if (control.CurrDish.NumberOfSells > 0)
                            result.Add(control.CurrDish);
                    }

                    foreach (CustomNumericUpDown control in menuSpecial.Controls.OfType<CustomNumericUpDown>())
                    {
                        if (control.CurrDish.NumberOfSells > 0)
                            result.Add(control.CurrDish);
                    }

                    Database.Instance.WriteCSV<Dish>(result, true);
                    break;
                case ExittingForm.CustomDialogResult.DONTSAVE:
                    break;
                case ExittingForm.CustomDialogResult.CANCEL:
                    e.Cancel = true;
                    break;
            }
        }

        private void UpdateTime()
        {
            TimeSpan currTime = DateTime.Now.TimeOfDay;
            TimeSpan morning = new TimeSpan(5, 30, 0);
            TimeSpan afternoon = new TimeSpan(12, 0, 0);
            TimeSpan evening = new TimeSpan(18, 0, 0);
            while (true)
            {
                try
                {
                    string time = DateTime.Now.ToString("hh:mm:ss tt, ") + DateTime.Now.ToString("dd/MM/yyyy");
                    if (WelcomeLabel.IsHandleCreated)
                    {
                        WelcomeLabel.Invoke(new Action(() =>
                        {
                            if (currTime >= morning && currTime < afternoon)
                                WelcomeLabel.Text = "Chào buổi sáng, bây giờ là " + time;
                            else if (currTime >= afternoon && currTime < evening)
                                WelcomeLabel.Text = "Chào buổi chiều, bây giờ là " + time;
                            else if (currTime >= evening || currTime < morning)
                                WelcomeLabel.Text = "Chào buổi tối, bây giờ là " + time;
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
        #endregion

        #region Build custom controls and Mediator
        public interface IMediator
        {
            void Notify(object sender, string mes);

            int GetIndex();

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
                    this.price.ChangeText(newPrice.ToString("#,##0"));
                }
            }

            public int GetIndex() // get index of three custom labels in flow panel
            {
                return name.IndexInParent(); // 3 labels are at the same position, so we just need one for returning value
            }

            public List<Control> GetControls()
            {
                return new List<Control>() { name, amount, price };
            }
        }
        //CustomeUpDown has medidator and currDish
        public partial class CustomNumericUpDown : NumericUpDown
        {
            private bool labelsVisibling;
            public bool LabelsVisibling
            {
                get => labelsVisibling;
                set => labelsVisibling = value;
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

            private decimal oldValue;
            public decimal OldValue
            {
                get => oldValue;
                set => oldValue = value;
            }
            //======================================
            public CustomNumericUpDown() : base()
            {
                labelsVisibling = false;
                mediator = null;
                oldValue = 0;
            }

            public void AttachDish(Dish dish)
            {
                currDish = dish;
            }

            public void ChangeValue()
            {
                mediator.Notify(this, this.Value.ToString());
            }

            public int GetIndex() // get index from 3 assiciative labels
            {
                if (mediator == null)
                    return -1;
                return mediator.GetIndex();
            }

            public override void UpButton()
            {
                // save state before chaging value
                FormMenu.Instance.caretaker.Backup(this);
                base.UpButton();
            }

            public override void DownButton()
            {
                // save state before chaging value
                FormMenu.Instance.caretaker.Backup(this);
                base.DownButton();
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
                this.Font = new Font("Segoe UI", 12);
            }

            public void ChangeText(string newText)
            {
                this.Text = newText;
            }

            public int IndexInParent()
            {
                if (this.Parent == null)
                    return -1;
                return this.Parent.Controls.IndexOf(this); // parent of this CustomLabel usually is FlowPanel
            }
        }
        public class CustomPanel : Panel
        {
            protected override Point ScrollToControl(Control activeControl)
            {
                // return the current location, prevent panel automatically scroll to the active control
                return this.DisplayRectangle.Location;
            }
        }
        #endregion

        #region load menu function (using Builder Design Pattern)
        private interface IBuilder
        {
            public PictureBox BuildPictureBox(int w, int h, int x, int y, string imagePath);
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

            public PictureBox BuildPictureBox(int w, int h, int x, int y, string imagePath)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(w, h);
                pb.Location = new Point(x, y);
                pb.BackColor = Color.White;
                pb.Image = pb.InitialImage;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                if (imagePath != null && File.Exists(imagePath))
                {
                    using (Bitmap temp = new Bitmap(imagePath))
                    {
                        pb.Image = new Bitmap(temp);
                    }
                }
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
                lblName.Font = new Font("Segoe UI", lblName.Font.Size + 2);
                return lblName;
            }
            public Label BuildLabelPrice(int w, int h, int x, int y, double price)
            {
                Label lblPrice = new Label();
                lblPrice.Size = new Size(w, h);
                lblPrice.Location = new Point(x, y);
                lblPrice.AutoSize = false;
                lblPrice.Text = price.ToString("#,##0") + " VND";
                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                lblPrice.Font = new Font("Segoe UI", lblPrice.Font.Size + 2);
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

                FormMenu form1 = FormMenu.Instance;

                decimal prevVal = Convert.ToDecimal(((UpDownBase)sender).Text); // value on textbox usually updates after value property
                if (prevVal == cnup.Value) // so if it's value equals to the current value property, that means user has input value by hand
                {
                    form1.caretaker.Backup(cnup); // so we back the state up
                    form1.caretaker.SetLast(cnup.OldValue, cnup.GetIndex());
                }
                cnup.OldValue = cnup.Value;

                if (cnup.Value <= 0)
                {
                    List<Control> controls = cnup.Mediator.GetControls();
                    form1.flowOrderName.Controls.Remove(controls[0]);
                    form1.flowOrderAmount.Controls.Remove(controls[1]);
                    form1.flowOrderPrice.Controls.Remove(controls[2]);
                    cnup.LabelsVisibling = false;

                    FormMenu.Instance.CalToTal();
                    return;
                }

                if (cnup.LabelsVisibling && cnup.Mediator != null) // if this object has initialized mediator already
                {
                    cnup.ChangeValue(); // then we just change the current text
                    FormMenu.Instance.CalToTal();
                    return;
                }
                else if (!cnup.LabelsVisibling && cnup.Mediator != null)
                {
                    List<Control> controls = cnup.Mediator.GetControls();
                    form1.flowOrderName.Controls.Add(controls[0]);
                    form1.flowOrderAmount.Controls.Add(controls[1]);
                    form1.flowOrderPrice.Controls.Add(controls[2]);

                    cnup.ChangeValue();
                    FormMenu.Instance.CalToTal();

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
                price.Text = (dish.Price * (double)cnup.Value).ToString("#,##0");
                price.AutoSize = true;
                price.Name = dish.ID.ToString() + ",Price";
                form1.flowOrderPrice.Controls.Add(price);
                // set newest control as breakpoint, so that is will appear vertically in the flow panel
                form1.flowOrderPrice.SetFlowBreak(price, true);

                // init mediator
                new ConcreteMediator(cnup, name, amount, price);
                cnup.LabelsVisibling = true;
                FormMenu.Instance.CalToTal();
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
            FoodLabel.Visible = DrinkLabel.Visible = ToppingLabel.Visible = SpecialLabel.Visible = true;
            temp.BringToFront();
            if (menuFood != temp) if (menuFood != null)
                {
                    menuFood.Visible = false;
                    FoodLabel.Visible = false;
                }
            if (menuDrink != temp) if (menuDrink != null)
                {
                    menuDrink.Visible = false;
                    DrinkLabel.Visible = false;
                }
            if (menuTopping != temp) if (menuTopping != null)
                {
                    menuTopping.Visible = false;
                    ToppingLabel.Visible = false;
                }
            if (menuSpecial != temp) if (menuSpecial != null)
                {
                    menuSpecial.Visible = false;
                    SpecialLabel.Visible = false;
                }
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

            for (int i = 0; i < sizeList; i++)
            {
                for (int j = 0; j < 3 && i < sizeList && iterDish.MoveNext(); j++, i++)
                {
                    //Build pictureBox
                    PictureBox pb = ConcreteBuilder.Instance.BuildPictureBox(width, height, xLocation, yLocation, iterDish.Current.GetImagePath());

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
        public void ReLoadMenu(Type type) // used after remove or add dish to display on form
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
            switchVisible(panelDishes);
        }
        #endregion

        #region load menu button by type 
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
        #endregion

        #region Save to Menu and Bill and refresh button
        private void RefreshBut_Click(object sender, EventArgs e)
        {
            if (TotalPrice.Text == "0")
            {
                return;
            }
            foreach (CustomNumericUpDown control in menuFood.Controls.OfType<CustomNumericUpDown>())
            {
                control.Value = 0;

            }

            foreach (CustomNumericUpDown control in menuDrink.Controls.OfType<CustomNumericUpDown>())
            {
                control.Value = 0;

            }

            foreach (CustomNumericUpDown control in menuTopping.Controls.OfType<CustomNumericUpDown>())
            {
                control.Value = 0;

            }

            foreach (CustomNumericUpDown control in menuSpecial.Controls.OfType<CustomNumericUpDown>())
            {
                control.Value = 0;

            }

            caretaker.ClearAll();
        }
        private void UpdateNRefresh(CustomNumericUpDown control)
        {
            //CustomNumericUpDown upDown = (CustomNumericUpDown)control;
            if (control.Value != 0)
            {
                control.CurrDish.NumberOfSells += Convert.ToInt32(control.Value);
                control.Value = 0;
            }

        }
        private void Pay_Click(object sender, EventArgs e)
        {
            //Save Bill
            if (Convert.ToDouble(TotalPrice.Text) == 0)
            {
                MessageBox.Show("Không có món cần thanh toán !!");
                return;
            }
            Bill newBill = new Bill();
            newBill.ModifyBill(flowOrderName, flowOrderAmount, flowOrderPrice);
            ListBill.Instance.Bills.Add(newBill);

            //Update on Menu and refresh
            foreach (CustomNumericUpDown control in menuFood.Controls.OfType<CustomNumericUpDown>())
            {
                UpdateNRefresh(control);
            }

            foreach (CustomNumericUpDown control in menuDrink.Controls.OfType<CustomNumericUpDown>())
            {
                UpdateNRefresh(control);
            }

            foreach (CustomNumericUpDown control in menuTopping.Controls.OfType<CustomNumericUpDown>())
            {
                UpdateNRefresh(control);
            }

            foreach (CustomNumericUpDown control in menuSpecial.Controls.OfType<CustomNumericUpDown>())
            {
                UpdateNRefresh(control);
            }

            caretaker.ClearAll();
        }
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
            TotalPrice.Text = total.ToString("#,##0");
        }
        #endregion

        #region Memento Design Pattern (1)
        public IMemento Save(CustomNumericUpDown control)
        {
            return new ConcreteMemento(control);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            CustomNumericUpDown val = memento.RestoreState();
            if (val.Value != 0)
                val.LabelsVisibling = true;
            int index = memento.GetIndex();

            if (val.Mediator != null)
            {
                List<Control> temp = val.Mediator.GetControls();
                CustomLabel name = (CustomLabel)temp[0];
                CustomLabel amount = (CustomLabel)temp[1];
                CustomLabel price = (CustomLabel)temp[2];

                if (index >= 0)
                {
                    flowOrderName.Controls.SetChildIndex(name, index);
                    flowOrderAmount.Controls.SetChildIndex(amount, index);
                    flowOrderPrice.Controls.SetChildIndex(price, index);
                }
            }
        }
        #endregion

        #region HotKeys
        private KeyHandler keyHandler;
        public const int WM_HOTKEY_MSG_ID = 0x0312;
        private void HandleHotKey()
        {
            caretaker.Undo();
        }

        protected override void WndProc(ref Message mes)
        {
            if (mes.Msg == WM_HOTKEY_MSG_ID)
                HandleHotKey();

            base.WndProc(ref mes);
        }

        #endregion
    }

    public partial class FormMain : Form
    {
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu.Instance.ApplicationClosing(ref e);
        }
    }

    #region Memento Design Pattern (2)
    public interface IMemento
    {
        public FormMenu.CustomNumericUpDown RestoreState();
        public int GetIndex();
        public void SetValueNIndex(decimal value, int index);
    }

    public class ConcreteMemento : IMemento
    {
        private FormMenu.CustomNumericUpDown control;
        private decimal value;
        private int index;

        public ConcreteMemento(FormMenu.CustomNumericUpDown control)
        {
            this.control = control;
            this.value = control.Value;
            this.index = control.GetIndex();
        }

        public FormMenu.CustomNumericUpDown RestoreState()
        {
            control.Value = value;
            return control;
        }

        public int GetIndex()
        {
            return index;
        }

        public void SetValueNIndex(decimal value, int index)
        {
            this.value = value;
            this.index = index;
        }
    }

    public class Caretaker
    {
        private List<IMemento> mementos;
        private FormMenu originator;

        public Caretaker(FormMenu originator)
        {
            this.originator = originator;
            mementos = new List<IMemento>();
        }

        public void Backup(FormMenu.CustomNumericUpDown control)
        {
            mementos.Add(originator.Save(control));
        }

        public void Undo()
        {
            if (mementos.Count == 0)
                return;

            IMemento memento = mementos.Last();
            mementos.RemoveAt(mementos.Count - 1); // remove the last

            try
            {
                originator.Restore(memento);
            }
            catch
            {
                Undo();
            }
        }

        public void ClearAll()
        {
            mementos.Clear();
        }

        public void SetLast(decimal value, int index) // set value and index of last item
        {
            mementos.Last().SetValueNIndex(value, index);
        }
    }
    #endregion

    #region Handling hot keys (for undo - redo operations)
    public class KeyHandler
    {
        // import api from dynamic library
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int MOD_CONTROL = 0x0002;

        private int key;
        private IntPtr hWnd;
        private int id;

        public KeyHandler(Keys key, Form form)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode()
        {
            return key ^ hWnd.ToInt32(); // xor
        }

        public bool Register()
        {
            return RegisterHotKey(hWnd, id, MOD_CONTROL, key);
        }

        public bool Unregister()
        {
            return UnregisterHotKey(hWnd, id);
        }
    }
    #endregion
}