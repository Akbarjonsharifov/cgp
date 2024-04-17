using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5
{
    public partial class Form1 : Form
    {
        private List<Point> points = new List<Point>();
        private List<Tuple<int, int>> lines = new List<Tuple<int, int>>();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = 1280;
            this.Height = 1024;

            points.Add(new Point(100, 100));
            points.Add(new Point(600, 100));
            points.Add(new Point(600, 300));
            points.Add(new Point(100, 300));
            
            points.Add(new Point(600, 100));
            points.Add(new Point(1100, 100));
            points.Add(new Point(1100, 200));
            points.Add(new Point(600, 200));

            points.Add(new Point(100, 300));
            points.Add(new Point(1100, 300));
            points.Add(new Point(1100, 400));
            points.Add(new Point(100, 400));

            

            lines.Add(new Tuple<int, int>(0, 1));
            lines.Add(new Tuple<int, int>(1, 2));
            lines.Add(new Tuple<int, int>(2, 3));
            lines.Add(new Tuple<int, int>(3, 0));
            
            lines.Add(new Tuple<int, int>(4, 5));
            lines.Add(new Tuple<int, int>(5, 6));
            lines.Add(new Tuple<int, int>(6, 7));
            lines.Add(new Tuple<int, int>(7, 4));

            lines.Add(new Tuple<int, int>(8, 9));
            lines.Add(new Tuple<int, int>(9, 10));
            lines.Add(new Tuple<int, int>(10, 11));
            lines.Add(new Tuple<int, int>(11, 8));

            

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (var line in lines)
            {
                Point p1 = points[line.Item1];
                Point p2 = points[line.Item2];
                g.DrawLine(Pens.Black, p1, p2);
            }
        }
    }
}
