namespace cgp_final_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.x_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.toolboxPanel = new System.Windows.Forms.Panel();
            this.brush_size = new System.Windows.Forms.NumericUpDown();
            this.colorbox = new System.Windows.Forms.PictureBox();
            this.eraser_button = new System.Windows.Forms.PictureBox();
            this.draw_button = new System.Windows.Forms.PictureBox();
            this.rectangle_btn = new System.Windows.Forms.PictureBox();
            this.circle_btn = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            this.toolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brush_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.rectangle_btn);
            this.TopPanel.Controls.Add(this.circle_btn);
            this.TopPanel.Controls.Add(this.x_Button);
            this.TopPanel.Controls.Add(this.clear_Button);
            this.TopPanel.Controls.Add(this.save_Button);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1512, 254);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // x_Button
            // 
            this.x_Button.Location = new System.Drawing.Point(1299, 12);
            this.x_Button.Name = "x_Button";
            this.x_Button.Size = new System.Drawing.Size(75, 85);
            this.x_Button.TabIndex = 3;
            this.x_Button.Text = "x";
            this.x_Button.UseVisualStyleBackColor = true;
            this.x_Button.Click += new System.EventHandler(this.x_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(1116, 119);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(128, 85);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(1103, 12);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(167, 85);
            this.save_Button.TabIndex = 1;
            this.save_Button.Text = "save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drawing Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.White;
            this.canvasPanel.Controls.Add(this.toolboxPanel);
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 254);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(1512, 600);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // toolboxPanel
            // 
            this.toolboxPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolboxPanel.Controls.Add(this.colorbox);
            this.toolboxPanel.Controls.Add(this.eraser_button);
            this.toolboxPanel.Controls.Add(this.draw_button);
            this.toolboxPanel.Controls.Add(this.brush_size);
            this.toolboxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolboxPanel.Location = new System.Drawing.Point(0, 0);
            this.toolboxPanel.Name = "toolboxPanel";
            this.toolboxPanel.Size = new System.Drawing.Size(279, 600);
            this.toolboxPanel.TabIndex = 0;
            this.toolboxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // brush_size
            // 
            this.brush_size.Location = new System.Drawing.Point(34, 299);
            this.brush_size.Name = "brush_size";
            this.brush_size.Size = new System.Drawing.Size(188, 31);
            this.brush_size.TabIndex = 0;
            this.brush_size.ValueChanged += new System.EventHandler(this.paintbrushsize_changed);
            // 
            // colorbox
            // 
            this.colorbox.BackColor = System.Drawing.SystemColors.Desktop;
            this.colorbox.Location = new System.Drawing.Point(34, 360);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(188, 98);
            this.colorbox.TabIndex = 3;
            this.colorbox.TabStop = false;
            this.colorbox.Click += new System.EventHandler(this.colorbox_Click);
            // 
            // eraser_button
            // 
            this.eraser_button.Image = ((System.Drawing.Image)(resources.GetObject("eraser_button.Image")));
            this.eraser_button.Location = new System.Drawing.Point(34, 159);
            this.eraser_button.Name = "eraser_button";
            this.eraser_button.Size = new System.Drawing.Size(188, 117);
            this.eraser_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eraser_button.TabIndex = 2;
            this.eraser_button.TabStop = false;
            this.eraser_button.Click += new System.EventHandler(this.eraser_button_Click);
            // 
            // draw_button
            // 
            this.draw_button.Image = ((System.Drawing.Image)(resources.GetObject("draw_button.Image")));
            this.draw_button.Location = new System.Drawing.Point(34, 6);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(188, 133);
            this.draw_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.draw_button.TabIndex = 1;
            this.draw_button.TabStop = false;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // rectangle_btn
            // 
            this.rectangle_btn.Image = global::cgp_final_project.Properties.Resources.rectangle;
            this.rectangle_btn.Location = new System.Drawing.Point(951, 119);
            this.rectangle_btn.Name = "rectangle_btn";
            this.rectangle_btn.Size = new System.Drawing.Size(124, 85);
            this.rectangle_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rectangle_btn.TabIndex = 5;
            this.rectangle_btn.TabStop = false;
            this.rectangle_btn.Click += new System.EventHandler(this.rectangle_btn_Click);
            // 
            // circle_btn
            // 
            this.circle_btn.Image = global::cgp_final_project.Properties.Resources.circle1;
            this.circle_btn.Location = new System.Drawing.Point(951, 13);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(124, 84);
            this.circle_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle_btn.TabIndex = 4;
            this.circle_btn.TabStop = false;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1512, 854);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Paint";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.canvasPanel.ResumeLayout(false);
            this.toolboxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brush_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle_btn)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Panel toolboxPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button x_Button;
        private System.Windows.Forms.NumericUpDown brush_size;
        private System.Windows.Forms.PictureBox draw_button;
        private System.Windows.Forms.PictureBox eraser_button;
        private System.Windows.Forms.PictureBox colorbox;
        private System.Windows.Forms.PictureBox circle_btn;
        private System.Windows.Forms.PictureBox rectangle_btn;
    }
}

