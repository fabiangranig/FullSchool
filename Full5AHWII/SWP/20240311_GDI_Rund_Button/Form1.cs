using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240311_GDI_Rund_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(3, 20, 53, 53);
            myPath.FillMode = FillMode.Alternate;
            this.button1.Region = new Region(myPath);
            this.button1.BackColor = Color.Brown;

            GraphicsPath myPath1 = new GraphicsPath();
            myPath1.AddEllipse(50, 30, 53, 53);
            myPath1.AddEllipse(5, 30, 53, 53);
            myPath1.AddPie(-11, 42, 130, 145, 225, 90);
            myPath1.FillMode = FillMode.Winding;
            this.button2.Region = new Region(myPath1);
            this.button2.BackColor = Color.Brown;

            GraphicsPath myPath3 = new GraphicsPath();
            myPath3.AddLine(new Point(50, 100), new Point(100, 50));
            myPath3.AddLine(new Point(0, 50), new Point(100, 50));
            myPath3.AddLine(new Point(0, 50), new Point(50, 100));
            myPath1.AddEllipse(50, 30, 53, 53);
            myPath1.AddEllipse(5, 30, 53, 53);
            myPath3.FillMode = FillMode.Winding;
            this.button3.Region = new Region(myPath3);
            this.button3.BackColor = Color.Brown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geklick!");
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            Pen myPen = new Pen(Color.Cyan);
            myGraphics.DrawString("Beenden", this.Font, Brushes.Red, 7, 40);
        }
    }
}
