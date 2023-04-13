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
            flowOrderName.SetFlowBreak(temp, true); // set newest control as breakpoint, so that is will appear vertically in the flow panel
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
                // calculate new location for form after drag-and-drop operation
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
    }
}