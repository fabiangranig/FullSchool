using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230110_GID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Zeichnen_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;

            Pen MyPen = new Pen(Color.Red);
            Brush MyBrush = new SolidBrush(Color.Blue);

            MyGraphics.DrawLine(MyPen, 0, 0, this.Size.Width, this.Size.Height);
            MyGraphics.DrawEllipse(MyPen, 10, 10, 20, 20);

            MyGraphics.FillEllipse(MyBrush, 150, 150, 40, 80);
        }
    }
}
