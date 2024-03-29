using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Use lamba function
            Paint += (object sender, PaintEventArgs e) => {

                PointF p1 = new Point(100, 100);
                PointF p2 = new Point(500, 100);
                PointF p3 = new Point(300, 446);

                string text = "Fractal Triangles";
                Font font = new Font("Arial", 14);
                PointF location = new PointF(10, 10);
                e.Graphics.DrawString(text, font, Brushes.Black, location);

                DrawTriangle(e.Graphics, p1, p2, p3);
            };

        }

        private void DrawTriangle(Graphics g, PointF p1, PointF p2, PointF p3)
        {
            // Limit to drawing only the number of 'numberOfTriangles' triangles, therefore if none left to draw then terminate the program.
            if (Distance(p1, p2) < 1 || Distance(p2, p3) < 1 || Distance(p3, p1) < 1)
                return;

            PointF midP1P2 = MidPoint(p1, p2);
            PointF midP2P3 = MidPoint(p2, p3);
            PointF midP3P1 = MidPoint(p3, p1);

            // Recursively draw the next triangle inside the current one
            DrawTriangle(g, midP1P2, midP2P3, midP3P1);
        }

        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }

        private double Distance(PointF p1, PointF p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}
