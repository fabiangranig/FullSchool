using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230110_FormWarmup
{
    public partial class Form1 : Form
    {
        private int _TitleHeight;

        public Form1()
        {
            InitializeComponent();
            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            this._TitleHeight = screenRectangle.Top - this.Top;
            this.ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;
            Pen MyPen = new Pen(Color.Black);
            Brush MyBrush = new SolidBrush(Color.Black);
            Brush MyBrush_Red = new SolidBrush(Color.Red);
            Brush MyBrush_Green = new SolidBrush(Color.Green);

            MyGraphics.DrawLine(MyPen, 0, (this.Size.Height - this._TitleHeight) / 2, this.Width, (this.Size.Height - this._TitleHeight) / 2);
            MyGraphics.DrawLine(MyPen, this.Width / 2, 0, this.Width / 2, this.Height - this._TitleHeight);

            MyGraphics.DrawEllipse(MyPen, this.Width / 4 - 75, (this.Height - _TitleHeight) / 4 - 75, 150, 150);
            MyGraphics.FillEllipse(MyBrush_Green, this.Width - this.Width / 4 - 100, (this.Height - _TitleHeight) / 4 - 75, 200, 150);
            MyGraphics.FillRectangle(MyBrush_Red, this.Width / 4 - 75, (this.Height / 2) - (this._TitleHeight / 2) + (this.Height - _TitleHeight) / 4 - 75, 150, 150);
            int start_x = this.Width - this.Width / 4;
            int start_y = ((this.Height / 2) - (this._TitleHeight / 2) + (this.Height - _TitleHeight) / 4 - 75);
            MyGraphics.DrawLine(MyPen, start_x, start_y, start_x + 100, start_y + 150);
            MyGraphics.DrawLine(MyPen, start_x, start_y, start_x - 100, start_y + 150);
            MyGraphics.DrawLine(MyPen, start_x + 100, start_y + 150, start_x - 100, start_y + 150);

            MyGraphics.DrawString("Kreis", new Font(FontFamily.GenericSansSerif, 10), MyBrush, this.Width / 4 - 15, (this.Height - this._TitleHeight) / 4 - 10);
            MyGraphics.DrawString("Ellipse", new Font(FontFamily.GenericSansSerif, 10), MyBrush, this.Width - (this.Width / 4 - 10) - 25, (this.Height - this._TitleHeight) / 4 - 10);
            MyGraphics.DrawString("Rechteck", new Font(FontFamily.GenericSansSerif, 10), MyBrush, this.Width / 4 - 30, (this.Height - this._TitleHeight) - 10 - (this.Height - this._TitleHeight) / 4);
            MyGraphics.DrawString("Dreieck", new Font(FontFamily.GenericSansSerif, 10), MyBrush, this.Width - (this.Width / 4 - 10) - 33, (this.Height - this._TitleHeight) + 15 - (this.Height - this._TitleHeight) / 4);
        }
    }
}
