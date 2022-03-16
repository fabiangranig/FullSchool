using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220316_Textboxen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addieren_Click(object sender, EventArgs e)
        {
            int zahl1, zahl2, ergebnis;

            zahl1 = Convert.ToInt32(this.txt_Zahl1.Text);
            zahl2 = Convert.ToInt32(this.txt_Zahl2.Text);

            ergebnis = zahl1 + zahl2;

            lbl_Ergebnis.Text = "Ergebnis: " + ergebnis.ToString();
        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
