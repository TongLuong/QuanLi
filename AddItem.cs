using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class AddItem : Form
    {
        private string baseDir;

        private string name;
        public string ItemName
        {
            get => name;
            set => name = value;
        }

        private double price;
        public double ItemPrice
        {
            get => price;
            set => price = value;
        }

        private double expense;
        public double ItemExpense
        {
            get => expense;
            set => expense = value;
        }
        private string imageName;
        public string ImageName
        {
            get => imageName;
            set => imageName = value;
        }

        private Type type;
        public Type ItemType
        {
            get => type;
            set => type = value;
        }

        private bool abort;
        public bool Abort
        {
            get => abort;
        }

        public AddItem()
        {
            InitializeComponent();
            this.ActiveControl = Accept;
            name = null;
            price = 0;
            expense = 0;
            imageName = null;
            type = Type.NONE;
            baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (Directory.Exists(baseDir + "\\Images\\Form1"))
            {
                baseDir = baseDir + "\\Images\\Form1\\";
            }
            else
            {
                int index = baseDir.IndexOf("bin");
                baseDir = baseDir.Substring(0, index) + "Images\\Form1\\";
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            name = itemName.Text;
            try
            {
                price = Convert.ToDouble(itemPrice.Text);
                expense = Convert.ToDouble(itemExpense.Text);
            }
            catch (Exception exc)
            {
                if (exc is FormatException)
                    MessageBox.Show(exc.Message + "\n" + "Please enter number only!");
                else if (exc is OverflowException)
                    MessageBox.Show(exc.Message + "\n" + "The number is too large!");

                return;
            }

            Enum.TryParse(itemType.SelectedItem.ToString(), out type);

            if (!File.Exists(itemImage.Text))
                imageName = "";
            else if (Path.GetExtension(itemImage.Text).ToLower() != ".png" && Path.GetExtension(itemImage.Text).ToLower() != ".jpg")
                imageName = "";

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            abort = true;
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            itemName.Text = "";
            itemPrice.Text = "";
            itemExpense.Text = "";
            itemImage.Text = "";
            imageName = "";
            if (itemType.Items.Count == 0)
            {
                foreach (string t in Enum.GetNames(typeof(Type)))
                {
                    itemType.Items.Add(t);
                }
            }
            itemType.SelectedIndex = 0;
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.png | *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageName = Path.GetFileName(ofd.FileName);
                itemImage.Text = Path.GetFullPath(ofd.FileName);
            }
        }
        public void AddImage()
        {
            if (itemImage.Text != "") File.Copy(itemImage.Text, baseDir + imageName, true);
        }
    }
}
