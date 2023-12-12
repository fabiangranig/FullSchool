using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231206_DemoTryCatch
{
    class NullException : Exception
    {
        public int Nummer;

        public NullException(int Nummer, string Messagetext) : base(Messagetext)
        {
            this.Nummer = Nummer;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double DIV(double a, double b)
        {
            if (b == 0)
                throw new NullException(1, "Nulldivision nicht möglich");

            return a / b;
        }

        private void button_Berechnen_Click(object sender, EventArgs e)
        {
            try
            {
                double Erg = DIV(2, 0);
                MessageBox.Show(Erg.ToString());
            }
            catch (NullException ex)
            {
                MessageBox.Show("Fehlernummer: " + ex.Nummer.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            finally
            {

            }
        }
    }
}
