using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class Form1 : Form
    {
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
    }
}
