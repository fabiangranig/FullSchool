using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20240124_MiniPaint
{
    public partial class Form_Paint : Form
    {
        private List<Point> _drawed_lines;
        private List<Point> _drawed_lines_end;


        private List<Point> point;
        private Graphics _Graphics;
        private bool _Draging;
        private bool _Painting;
        private int _currentPosX, _currentPosY;
        private int _extraYSize;
        private int _previousX, _previousY;

        public Form_Paint()
        {
            InitializeComponent();
            this._drawed_lines = new List<Point>();
            this._drawed_lines_end = new List<Point>();

            this.point = new List<Point>();
            this._Graphics = this.pictureBox_PaintingField.CreateGraphics();
            this._extraYSize = menuStrip1.Size.Height + this.toolStrip1.Size.Height;
        }

        private void pictureBox_PaintingField_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripStatusLabel_currentMousePosition.Text = e.Location.ToString();

            if(this._Painting)
            {
                this._drawed_lines.Add(new Point(this._previousX, this._previousY));
                this._drawed_lines_end.Add(new Point(e.X, e.Y));
                this._previousX = e.X;
                this._previousY = e.Y;
                this.pictureBox_PaintingField.Invalidate();
            }
        }

        private void pictureBox_ResizeDiagonal_MouseDown(object sender, MouseEventArgs e)
        {
            this._Draging = true;
            this._currentPosX = Cursor.Position.X;
            this._currentPosY = Cursor.Position.Y;
        }

        private void pictureBox_ResizeDiagonal_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._Draging)
            {
                this.pictureBox_ResizeDiagonal.Left += Cursor.Position.X - this._currentPosX;
                this._currentPosX = Cursor.Position.X;
                this.pictureBox_ResizeDiagonal.Top += Cursor.Position.Y - this._currentPosY;
                this._currentPosY = Cursor.Position.Y;
                point.Add(e.Location);
            }
        }

        private void pictureBox_PaintingField_MouseDown(object sender, MouseEventArgs e)
        {
            this._Painting = true;
            point.Add(e.Location);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.pictureBox_PaintingField.Width, this.pictureBox_PaintingField.Height);
            Rectangle rect = new Rectangle(0, 0, this.pictureBox_PaintingField.Width, this.pictureBox_PaintingField.Height);
            this.pictureBox_PaintingField.DrawToBitmap(bmp, rect);
            bmp.Save("NPC.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void pictureBox_PaintingField_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen_black = new Pen(Color.Black);
            pen_black.Width = 100;
            pen_black.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen_black.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            for(int i = 0; i < this._drawed_lines.Count; i++)
            {
                graphics.DrawLine(pen_black, this._drawed_lines[i], this._drawed_lines_end[i]);
            }
        }


        private void pictureBox_PaintingField_MouseUp(object sender, MouseEventArgs e)
        {
            this._Painting = false;
            point.Add(e.Location);
        }

        private void pictureBox_ResizeDiagonal_MouseUp(object sender, MouseEventArgs e)
        {
            this._Draging = false;
            this.pictureBox_PaintingField.Size = new Size(this.pictureBox_ResizeDiagonal.Left, this.pictureBox_ResizeDiagonal.Top - 10 - this._extraYSize);
        }
    }
}
