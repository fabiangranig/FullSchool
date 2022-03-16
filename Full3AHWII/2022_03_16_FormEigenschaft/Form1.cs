using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220316_FormEigenschaft
{
    public partial class Form_Window : Form
    {
        public Form_Window()
        {
            InitializeComponent();
        }

        private void Form_Start(object sender, EventArgs e)
        {
            //Den Usernamen hinzufügen
            this.Text = "Username: " + Environment.UserName;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            //Das Programm schließen
            this.Close();
        }

        private void button_change_Layout_Click(object sender, EventArgs e)
        {
            //Ändern des Layouts
            this.Width = Screen.PrimaryScreen.Bounds.Width / 2;
            this.Height = Screen.PrimaryScreen.Bounds.Height / 2;
            this.Font = this.Font = new Font("Arial", 12);
            this.Text = "geändertes Layout";
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            this.Opacity = 0.5;
            button_change_Layout.Height = 200;
            button_layout_reset.Height = 200;
            button_Ok.Height = 200;
            this.BackColor = Color.Pink;
            button_change_Layout.BackColor = Color.Pink;
            button_layout_reset.BackColor = Color.Pink;
            button_Ok.BackColor = Color.Pink;
            button_change_Layout.ForeColor = Color.Blue;
            button_layout_reset.ForeColor = Color.Blue;
            button_Ok.ForeColor = Color.Blue;
            label_text.ForeColor = Color.Blue;
        }

        private void button_layout_reset_Click(object sender, EventArgs e)
        {
            //Ändern des Layouts
            this.Width = 480;
            this.Height = 200;
            this.Font = this.Font = new Font("Times New Roman", 12);
            this.Text = "Username: " + Environment.UserName;
            this.CenterToScreen();
            this.Opacity = 1;
            button_change_Layout.Height = 34;
            button_layout_reset.Height = 34;
            button_Ok.Height = 34;
            this.BackColor = Color.Blue;
            button_change_Layout.BackColor = Color.Blue;
            button_layout_reset.BackColor = Color.Blue;
            button_Ok.BackColor = Color.Blue;
            button_change_Layout.ForeColor = Color.White;
            button_layout_reset.ForeColor = Color.White;
            button_Ok.ForeColor = Color.White;
            label_text.ForeColor = Color.White;
        }
    }
}
