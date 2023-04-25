using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class DeleteItem : Form
    {
        #region inital value
        private bool abort; public bool Abort { get => abort; set => abort = value; }
        private string baseDir, dataDir, imagesDir;
        private Dish delDish;
        private DataTable dt;
        #endregion
        public DeleteItem()
        {
            InitializeComponent();
            baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int index = baseDir.IndexOf("bin");
            dataDir = baseDir.Substring(0, index) + "Data\\Dish.csv";
            imagesDir = baseDir.Substring(0, index) + "Images\\Form1\\";
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên Món");
            dt.Columns.Add("Giá tiền");
            dt.Columns.Add("Chi phí");
            dt.Columns.Add("Số lượng bán được");
            dt.Columns.Add("Loại");
            dt.Columns.Add("Ảnh");
            abort = false;
        }

        #region show list menu
        public void ShowMenu()
        {
            dt.Clear();
            using (StreamReader rd = new StreamReader(dataDir))
            {
                while (!rd.EndOfStream)
                {
                    string[] rows = rd.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            MenuAll.DataSource = dt;

        }
        #endregion
        #region button
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            abort = true;
            this.Close();
        }
        #endregion

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MenuAll.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return;

                //get infor
                int index = MenuAll.SelectedRows[0].Index;
                imagesDir = baseDir.Substring(0, baseDir.IndexOf("bin")) + "Images\\Form1\\"+ MenuAll.Rows[index].Cells[6].Value.ToString();
                string id = MenuAll.Rows[index].Cells[0].Value.ToString();
                //get dish
                List<Dish> all = Menu.Instance.GetAllDishes();
                IEnumerator<Dish> it = all.GetEnumerator();
                while (it.MoveNext())
                {
                    if (it.Current.ID == id)
                    {
                        delDish = it.Current;
                        break;
                    }
                }
                //delete
                Type type = delDish.Type;
                if (!Menu.Instance.RemoveDish(delDish)) return;
                if (MenuAll.Rows[index].Cells[6].Value.ToString() != "") File.Delete(imagesDir);
                MenuAll.Rows.RemoveAt(index);
                Database.Instance.WriteCSV<Dish>(Menu.Instance.GetAllDishes(), false,true);
                Form1.Instance.ReLoadMenu(type);
                abort = false;
                this.Close();
            }

        }
    }
}
