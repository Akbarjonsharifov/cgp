using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(OnPaint);
            
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Blue, 1);
            Pen myPen2 = new Pen(Color.Red, 1);

           
            graphics.DrawRectangle(myPen, 150, 50, 200, 100);

            
            Tmatrix myTmatrix = new Tmatrix();
            Matrix myMatrix = myTmatrix.matrixRotate(45, 250, 100); 

            
            graphics.Transform = myMatrix;

            
            graphics.DrawRectangle(myPen2, 150, 150, 200, 100);

            
            graphics.ResetTransform();
        }





        public class Tmatrix
        {
            public Matrix matrixRotate(float angle, float centerX, float centerY)
            {
                Matrix matrix = new Matrix();
                matrix.RotateAt(angle, new PointF(centerX, centerY), MatrixOrder.Append);
                return matrix;
            }
        }
    }
}
