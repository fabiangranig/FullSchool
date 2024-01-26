using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20240124_MiniPaint
{
    public partial class Form_Paint : Form
    {
        private Graphics _Graphics;
        private bool _Draging;
        private bool _Painting;
        private int _currentPosX, _currentPosY;
        private int _extraYSize;

        public Form_Paint()
        {
            InitializeComponent();
            this._Graphics = this.pictureBox_PaintingField.CreateGraphics();
            this._extraYSize = menuStrip1.Size.Height + this.toolStrip1.Size.Height;
        }

        private void pictureBox_PaintingField_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripStatusLabel_currentMousePosition.Text = e.Location.ToString();

            if(this._Painting)
            {
                Pen pen_black = new Pen(Color.Black);
                this._Graphics.DrawLine(pen_black, new Point(e.Location.X, e.Location.Y), new Point(e.Location.X + 10, e.Location.Y + 10));
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
            }
        }

        private void pictureBox_PaintingField_MouseDown(object sender, MouseEventArgs e)
        {
            this._Painting = true;
        }

        private void pictureBox_PaintingField_MouseUp(object sender, MouseEventArgs e)
        {
            this._Painting = false;
        }

        private void pictureBox_ResizeDiagonal_MouseUp(object sender, MouseEventArgs e)
        {
            this._Draging = false;
            this.pictureBox_PaintingField.Size = new Size(this.pictureBox_ResizeDiagonal.Left, this.pictureBox_ResizeDiagonal.Top - 10 - this._extraYSize);
        }
    }
}
