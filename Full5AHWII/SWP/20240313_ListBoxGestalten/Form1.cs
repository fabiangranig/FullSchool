using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240313_ListBoxGestalten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.listBox1.DrawMode = DrawMode.OwnerDrawVariable;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if(e.Index >= 0)
            {
                string Help = this.listBox1.Items[e.Index].ToString();

                Pen myPen = new Pen(Color.Black);
                Color[] myColor = { Color.Beige, Color.Red, Color.White, Color.Green, Color.Black, Color.Azure, Color.Pink };
                SolidBrush myBrush = new SolidBrush(myColor[e.Index % 7]);
                e.Graphics.FillRectangle(myBrush, e.Bounds);
                e.Graphics.DrawString(Help, this.Font, Brushes.Blue, new Point(e.Bounds.X, e.Bounds.Y));

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    Pen myPen1 = new Pen(Color.Blue);

                    e.Graphics.FillRectangle(new SolidBrush(Color.Cyan), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                    e.Graphics.DrawRectangle(new Pen(Color.DarkOrange), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                    e.Graphics.DrawString(Help, this.Font, Brushes.HotPink, new Point(e.Bounds.X, e.Bounds.Y));
                }
            }
        }

        private void button_Befuellen_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                this.listBox1.Items.Add("Test" + (i + 1));
            }
            this.Invalidate();
        }
    }
}
