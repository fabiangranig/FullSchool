using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240304_MeineBibliothekFramework
{
    public partial class UserTextBox : UserControl
    {
        private string _Text;

        public string TextBeschreibung { 
            get { return this._Text; } 
            set { 
                this._Text = value;
                this.Invalidate();
            } 
        }

        public UserTextBox()
        {
            InitializeComponent();
        }

        private void UserTextBox_Load(object sender, EventArgs e)
        {
            this._Text = "Hallo";
        }

        private void UserTextBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics MyGraph = e.Graphics;
            MyGraph.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1));
            MyGraph.FillRectangle(new SolidBrush(Color.White), 1, 1, this.Size.Width - 2, this.Size.Height - 2);
            MyGraph.DrawString(this._Text, this.Font, new SolidBrush(Color.Aqua), 10, 10);
        }

        private void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this._Text += e.KeyChar;
            this.Invalidate();
        }
    }
}
