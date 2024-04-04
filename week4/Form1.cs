using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        int xVelocity = 1;
        int yVelocity = 1;
        int rectSize = 50;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Width = 400;
            this.Height = 400;

            rect = new Rectangle(0, 200, rectSize, rectSize);

            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (sender, e) => this.Invalidate();
            timer.Start();
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            base.OnPaint(e);


            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush whiteBrush = new SolidBrush(Color.White);
            Font myFont = new  System.Drawing.Font("Helvetica", 9);

            g.FillRectangle(whiteBrush, 0, 0, this.Width, this.Height);

            g.DrawRectangle(blackPen, rect);
            g.DrawString("Moving rectangle", myFont, redBrush, 150, 150);

            rect.X += xVelocity;
            rect.Y += yVelocity;

            if (rect.Right >= this.Width || rect.Left <= 0) xVelocity = -xVelocity;
            if (rect.Bottom >= this.Height || rect.Top <= 0) yVelocity = -yVelocity;
        }
    }
}
