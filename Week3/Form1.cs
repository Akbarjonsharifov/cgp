using System;
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
        System.Windows.Forms.Timer timer;
        int x = 0, y = 0;
        bool isMovingDownRight = true;
        //Graphics g;
        public Form1()
        {
            InitializeComponent();

            
            aRect = new Rectangle(100, 100, 200, 200);
            anEllipse = new Rectangle(150, 150, 200, 100);
            moving = new Rectangle(x, y, 10, 10);
            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;

            timer = new System.Windows.Forms.Timer
            {
                Interval = 10
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isMovingDownRight)
            {
                x++;
                y++;
            }
            else
            {
                x--;
                y--;
            }

            if (x > this.Width - moving.Width || y > this.Height - moving.Height || x < 0 || y < 0)
            {
                isMovingDownRight = !isMovingDownRight;
            }

            moving.Location = new Point(x, y);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                using(Brush redBrush = new SolidBrush(Color.Red))
                
                using (Brush movingBrush = new SolidBrush(Color.FromArgb(255, 255 - (x % 256), 255 - (y % 256))))
                {
                    g.FillRectangle(movingBrush, moving);
                }
            }
        }
    }
}

static class Program
{
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}
