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


        private bool paint = false;

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

        //

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;  // Record the position where the user clicked

            if (circleBounds.Contains(e.Location))
            {
                isDraggingCircle = true;  // Start dragging only if inside the circle
            }
            else
            {
                paint = true;  // Start drawing if not clicking on the circle
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDraggingCircle)
                {
                    int deltaX = e.X - old.X;
                    int deltaY = e.Y - old.Y;

                    // Move the circle's bounds
                    circleBounds.X += deltaX;
                    circleBounds.Y += deltaY;

                    // Redraw the entire canvas
                    graph.Clear(Color.White);  // Clear to avoid ghosting
                    graph.DrawEllipse(pen, circleBounds);  // Redraw the circle at new position
                    canvasPanel.Invalidate();  // Refresh the panel

                    old = e.Location;  // Update the old position for next movement
                }
                else if (paint)
                {
                    current = e.Location;
                    g.DrawLine(pen, old, current);
                    graph.DrawLine(pen, old, current);
                    old = current;
                    canvasPanel.Invalidate();  // Refresh the panel for drawing
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
            if (isDraggingCircle)
            {
                isDraggingCircle = false;  // Stop dragging the circle
            }
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

       
        }
    }

