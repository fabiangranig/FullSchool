using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220328_numDropDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Berechnen_Click(object sender, EventArgs e)
        {
            //Anzeigen der Textbox mit dem Ergebnis
            double o = Convert.ToDouble(txtNettobetrag.Text) * Convert.ToDouble(numericUpDown1.Value) / 100 + Convert.ToDouble(txtNettobetrag.Text);
            Label_letztes_Ergebnis.Text = "letztes Ergebnis: " + o;
            MessageBox.Show("Bruttobetrag: " + o);
        }
    }
}
