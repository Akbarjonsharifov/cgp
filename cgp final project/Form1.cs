using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace cgp_final_project
{

    
    public partial class Form1 : Form
    {
        // Setting up Variables 
        public Point current = new Point();
        public Point old = new Point();


        public Graphics g;
        public Graphics graph;

        public Pen pen = new Pen(Color.Black, 5);
        int index;

        private bool isDraggingCircle = false;
        private Rectangle circleBounds;  // This will store the circle's position and size
        private Rectangle rectangleBounds;

        private Rectangle triangleBounds; // To store the triangle's bounding box
        private bool isDraggingTriangle = false;


        private bool paint = false;
        private bool isDraggingRectangle = false;
        private Point[] triangleVertices = new Point[3];

        Bitmap surface;


        public Form1()
        {

            InitializeComponent();


           // Initializing variables 

            g = canvasPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(canvasPanel.Width, canvasPanel.Height);
            graph = Graphics.FromImage(surface);

            canvasPanel.BackgroundImage = surface;
            canvasPanel.BackgroundImageLayout = ImageLayout.None;
           







        pen.Width = (float)brush_size.Value;
        }
        // 
        private void MoveShape(ref Rectangle bounds, MouseEventArgs e)
        {
            int deltaX = e.X - old.X;
            int deltaY = e.Y - old.Y;

            // Move the bounds
            bounds.X += deltaX;
            bounds.Y += deltaY;

            // Redraw the entire canvas
            RedrawCanvas();
            old = e.Location;  // Update the old position for next movement
        }

        private void MoveTriangle(MouseEventArgs e)
        {
            int deltaX = e.X - old.X;
            int deltaY = e.Y - old.Y;

            for (int i = 0; i < triangleVertices.Length; i++)
            {
                triangleVertices[i].Offset(deltaX, deltaY);
            }

            RedrawCanvas(); // Clear and redraw the canvas
            old = e.Location;
        }

        private void DrawTriangle()
        {
            graph.DrawPolygon(pen, triangleVertices);
            canvasPanel.Invalidate(); // This assumes that graph is a Graphics object for the 'surface' bitmap
        }
        //

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(surface, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Optional painting logic for toolboxPanel
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        // function canvas_MouseDown

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;  // Record the position where the user clicked

            if (rectangleBounds.Contains(e.Location))
            {
                isDraggingRectangle = true;
            }
            else if (circleBounds.Contains(e.Location))
            {
                isDraggingCircle = true;
            }
            else if (triangleBounds.Contains(e.Location)) // Check if the click is within the triangle's bounding box
            {
                isDraggingTriangle = true;
            }
            else
            {
                paint = true;
            }
        }

        private void RedrawCanvas()
        {
            graph.Clear(Color.White); // Clear the canvas
            graph.DrawEllipse(pen, circleBounds); // Redraw the circle
            graph.DrawRectangle(pen, rectangleBounds); // Redraw the rectangle
            DrawTriangle();
        }

        private void DrawLine(MouseEventArgs e)
        {
            current = e.Location;
            g.DrawLine(pen, old, current);
            graph.DrawLine(pen, old, current);
            old = current;
            canvasPanel.Invalidate();   // Refresh the panel to show the new line
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDraggingCircle)
                {
                    MoveShape(ref circleBounds, e);
                }
                else if (isDraggingRectangle)
                {
                    MoveShape(ref rectangleBounds, e);
                }
                else if (isDraggingTriangle)
                {
                    MoveTriangle(e); // Implement this function
                }
                else if (paint)
                {
                    DrawLine(e);
                }
            }
        }

        private Point mouseOffsetPos;
        private Boolean isMouseDown = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseOffsetPos = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = Control.MousePosition;
            mousePos.Offset(mouseOffsetPos.X, mouseOffsetPos.Y);
            //this.Location = mousePos;
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void x_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eraser_button_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            pen.Color = colorbox.BackColor;
        }

        // method for drawing a circle 

        private void circle_btn_Click(object sender, EventArgs e)
        {
            int circleDiameter = 100;  // Diameter of the circle
            int circleRadius = circleDiameter / 2;
            int circleX = (canvasPanel.Width - circleDiameter) / 2;  // Center the circle on the canvas
            int circleY = (canvasPanel.Height - circleDiameter) / 2;

            circleBounds = new Rectangle(circleX, circleY, circleDiameter, circleDiameter);

            // Draw the circle on the bitmap for persistence
            graph.DrawEllipse(pen, circleBounds);
            canvasPanel.Invalidate();
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingCircle = false;
            isDraggingRectangle = false;
            isDraggingTriangle = false;
            paint = false;
        }

        // update creating circle 




        //

        private void colorbox_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
                colorbox.BackColor = cd.Color;
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            canvasPanel.Invalidate();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Png Files (*png) | *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void paintbrushsize_changed(object sender, EventArgs e)
        {
            pen.Width = (float)brush_size.Value;
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //  drawing a rectangle 

        private void rectangle_btn_Click(object sender, EventArgs e)
        {
            int rectangleWidth = 150;
            int rectangleHeight = 100;
            int rectangleX = (canvasPanel.Width - rectangleWidth) / 2;
            int rectangleY = (canvasPanel.Height - rectangleHeight) / 2;

            rectangleBounds = new Rectangle(rectangleX, rectangleY, rectangleWidth, rectangleHeight);

            RedrawCanvas();
        }
        // drawing a triangle 

        private void DrawTriangle(Point vertex1, Point vertex2, Point vertex3)
        {
            // Create an array of points to represent the vertices of the triangle
            Point[] trianglePoints = { vertex1, vertex2, vertex3 };

            // Use the Graphics object to draw the triangle
            graph.DrawPolygon(pen, trianglePoints);

            // Refresh the canvas panel to update the display
            canvasPanel.Invalidate();
        }

        private void triangle_btn_Click(object sender, EventArgs e)
        {
            int baseLength = 200;  // Base length of the triangle
            int height = 96;  // Height of the triangle

            triangleVertices[0] = new Point(canvasPanel.Width / 2, canvasPanel.Height / 2 - height / 2);
            triangleVertices[1] = new Point(canvasPanel.Width / 2 - baseLength / 2, canvasPanel.Height / 2 + height / 2);
            triangleVertices[2] = new Point(canvasPanel.Width / 2 + baseLength / 2, canvasPanel.Height / 2 + height / 2);

            // Draw the initial triangle
            DrawTriangle();

            // Set or update the bounding box for the triangle
            triangleBounds = new Rectangle(triangleVertices[1].X, triangleVertices[0].Y, baseLength, height);
        }
    }
    }
 

