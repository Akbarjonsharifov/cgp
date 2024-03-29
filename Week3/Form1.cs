﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace Week3
{
    public partial class Form1 : Form
    {
        Rectangle aRect;
        Rectangle anEllipse;
        Rectangle moving;
        int x = 0, y = 0;
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            // set up the rectangle objects using client (form) coordinates
            aRect = new Rectangle(100, 100, 200, 200);
            anEllipse = new Rectangle(150, 150, 200, 100);
            moving = new Rectangle(x, y, 10, 10);
            // size and position the frame
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            Brush redBrush = new SolidBrush(Color.Red);
            g.FillRectangle(redBrush, aRect);
            Brush greenBrush = new SolidBrush(Color.Green);
            g.FillEllipse(greenBrush, anEllipse);
        }
    }
    public class XORDemo
    {
        public static void Main ()
        {
            Application.Run(new Form1());
        }
    }
}
