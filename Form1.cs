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

        public Form1() => InitializeComponent();

        private void Order_Click(object sender, EventArgs e)
        {
            Label temp = new Label();
            temp.Text = "this is a very long textttttt";
            temp.AutoSize = true;

            flowOrderName.Controls.Add(temp);
            flowOrderName.SetFlowBreak(temp, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(0, 0, 1);
            //this.TransparencyKey = Color.FromArgb(0, 0, 1);
            timeThread = new Thread(() => UpdateTime());
            timeThread.IsBackground = true;
            timeThread.Start();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool MouseIsOverControl(Control c)
        => c.ClientRectangle.Contains(c.PointToClient(Cursor.Position));

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(close))
            {
                close.BorderStyle = BorderStyle.None;
                timer1.Stop();
            }
            else
                close.BorderStyle = BorderStyle.FixedSingle;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void minimize_MouseMove(object sender, MouseEventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(minimize))
            {
                minimize.BorderStyle = BorderStyle.None;
                timer2.Stop();
            }
            else
                minimize.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
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
                if (CurrTime.IsHandleCreated)
                {
                    CurrTime.Invoke(new Action(() =>
                    {
                        CurrTime.Text = DateTime.Now.ToString("hh:mm:ss tt ") + DateTime.Now.ToString("dd/MM/yyyy");
                    }));
                }
                Thread.Sleep(100);
            }
        }
    }
}
