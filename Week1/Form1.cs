using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e); // Call the base class OnPaint method
            Graphics g = e.Graphics;

            // Define the bounds for the square which will contain the circle
            Rectangle boundsForCircle = new Rectangle(200, 200, 100, 100);

            // Create a pen object for drawing
            using (Pen blackPen = new Pen(Color.Black))
            {
                // Draw an ellipse within the defined bounds
                // Since the bounds form a square, the ellipse will be a circle
                g.DrawEllipse(blackPen, boundsForCircle);
            }
        }
    }
}
