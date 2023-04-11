using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class Form1 : Form
    {
        private Rectangle pb1;
        private Rectangle pb2;
        private Rectangle originalFormSize;

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Height);
            pb1 = new Rectangle(pbMenu.Location.X, pbMenu.Location.Y, pbMenu.Size.Width, pbMenu.Size.Height);
            pb2 = new Rectangle(pbOrder.Location.X, pbOrder.Location.Y, pbOrder.Size.Width, pbOrder.Size.Height);
        }

        private void resizeControl(Rectangle r, Control c)
        {
            double xRatio = (double)r.Width / (double)originalFormSize.Width;
            double yRatio = (double)r.Height / (double)originalFormSize.Height;

            double xLocRatio = (double)r.Width / (double)r.X;
            double yLocRatio = (double)r.Height / (double)r.Y;

            int newX = (int)(r.X * xLocRatio);
            int newY = (int)(r.Y * yLocRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            //c.Location = new Point(newX, newX);
            //c.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(pb1, pbMenu);
            resizeControl(pb2, pbOrder);
        }
    }
}
