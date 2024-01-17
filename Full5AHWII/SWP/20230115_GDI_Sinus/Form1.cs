using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace _20230115_GDI_Sinus
{
    public partial class Form1 : Form
    {
        private int _TitleHeight;
        private Graphics _PictureBoxGrapics;
        private bool _ShowQuadraticFunction;

        public Form1()
        {
            InitializeComponent();
            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            this._TitleHeight = screenRectangle.Top - this.Top;
            this.pictureBox_Sinus.Location = new Point(130, 0);
            this.pictureBox_Sinus.Width = this.Width - 130;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.pictureBox_Sinus.Width = this.Width - 130;
            this.pictureBox_Sinus.Height = this.Height - this._TitleHeight;
            this.pictureBox_Sinus.Refresh();
        }

        private void pictureBox_Sinus_Paint(object sender, PaintEventArgs e)
        {
            //Pens
            Pen pen_black = new Pen(Color.Black);
            SolidBrush solidbrush_black = new SolidBrush(Color.Black);

            //Graphics
            Graphics graphics = e.Graphics;
            DrawCordinateSystem(e.Graphics, pen_black);
            graphics.TranslateTransform(this.pictureBox_Sinus.Width / 2, this.pictureBox_Sinus.Height / 2);
            DrawCordinateSystemNumber(e.Graphics, pen_black, solidbrush_black);
            DrawCordinateSystemSinus(e.Graphics, pen_black);

            try
            {
                int a = Int32.Parse(this.textBox_a.Text);
                int d = Int32.Parse(this.textBox_d.Text);
                int e1 = Int32.Parse(this.textBox_e.Text);
                DrawCordinateSystemQuadratic(e.Graphics, new Pen(Color.Black), a, d, e1);
            }
            catch (Exception exception) { }
        }

        private void DrawCordinateSystem(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, 0, this.pictureBox_Sinus.Height / 2, this.pictureBox_Sinus.Width, this.pictureBox_Sinus.Height / 2);
            graphics.DrawLine(pen, this.pictureBox_Sinus.Width / 2, 0, this.pictureBox_Sinus.Width / 2, this.pictureBox_Sinus.Height);
        }

        private void DrawCordinateSystemNumber(Graphics graphics, Pen pen, SolidBrush brush)
        {
            int one_tile_width = this.pictureBox_Sinus.Width / 2 / 10;
            
            //Right side
            for(int i = 0; i < 10; i++)
            {
                int incremented = i + 1;
                graphics.DrawLine(pen, incremented * one_tile_width, 5, incremented * one_tile_width, -5);
                graphics.DrawString(Convert.ToString(incremented), new Font(FontFamily.GenericSansSerif, 10), brush, incremented * one_tile_width - 5, 5);
            }

            //Left side
            for(int i = 0; i > -10; i--)
            {
                int decremented = i - 1;
                graphics.DrawLine(pen, decremented * one_tile_width, 5, decremented * one_tile_width, -5);
                graphics.DrawString(Convert.ToString(decremented), new Font(FontFamily.GenericSansSerif, 10), brush, decremented * one_tile_width - 8, 5);
            }

            int one_tile_height = this.pictureBox_Sinus.Height / 2 / 10;

            //Top side
            for (int i = 0; i < 10; i++)
            {
                int incremented = i + 1;
                graphics.DrawLine(pen, 5, incremented * one_tile_height, -5, incremented * one_tile_height);
                graphics.DrawString(Convert.ToString(incremented * -1), new Font(FontFamily.GenericSansSerif, 10), brush, 10, incremented * one_tile_height - 8);
            }

            //Left side
            for (int i = 0; i > -10; i--)
            {
                int decremented = i - 1;
                graphics.DrawLine(pen, 5, decremented * one_tile_height, -5, decremented * one_tile_height);
                graphics.DrawString(Convert.ToString(decremented * -1), new Font(FontFamily.GenericSansSerif, 10), brush, 10, decremented * one_tile_height - 8);
            }
        }

        private void DrawCordinateSystemSinus(Graphics graphics, Pen pen)
        {
            int one_tile_width = this.pictureBox_Sinus.Width / 2 / 10;
            int one_tile_height = this.pictureBox_Sinus.Height / 2 / 10;

            Point[] points = new Point[20];
            int u = 0;
            for(int i = -10; i < 10; i++)
            {
                points[u] = new Point(i * one_tile_width, Convert.ToInt32(Math.Sin(i) * one_tile_height));
                u++;
            }
            graphics.DrawCurve(pen, points);
        }

        private void DrawCordinateSystemQuadratic(Graphics graphics, Pen pen, int a, int d, int e) 
        {
            int one_tile_width = this.pictureBox_Sinus.Width / 2 / 10;
            int one_tile_height = this.pictureBox_Sinus.Height / 2 / 10;

            Point[] points = new Point[20];
            int u = 0;
            for (int i = -10; i < 10; i++)
            {
                points[u] = new Point(i * one_tile_width, Convert.ToInt32(((a * -1) * Math.Pow(i - d, 2) + e * -1) * one_tile_height));
                u++;
            }
            graphics.DrawCurve(pen, points);
        }

        private void textbox_TextChange(object sender, EventArgs e)
        {
            this.pictureBox_Sinus.Refresh();
        }
    }
}
