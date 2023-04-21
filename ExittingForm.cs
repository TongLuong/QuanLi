using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class ExittingForm : Form
    {
        public enum CustomDialogResult
        {
            SAVE,
            DONTSAVE,
            CANCEL
        }

        private CustomDialogResult result;
        public CustomDialogResult Result
        {
            get => result;
            set => result = value;
        }

        public ExittingForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            result = CustomDialogResult.SAVE;
            this.Close();
        }

        private void DSave_Click(object sender, EventArgs e)
        {
            result = CustomDialogResult.DONTSAVE;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            result = CustomDialogResult.CANCEL;
            this.Close();
        }
    }
}
