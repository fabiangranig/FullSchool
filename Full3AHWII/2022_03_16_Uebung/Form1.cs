using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220316_Uebung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Berechne_Click(object sender, EventArgs e)
        {
            //Textbox Teiler clearen
            textBox_Teiler.Text = "";

            //Teiler berechnen
            int zahl = Convert.ToInt32(textBox_Zahl.Text);
            int i = 1;
            while(zahl >= i)
            {
                //Werte ausgeben welche dividiert werden können
                if(zahl % i == 0)
                {
                    textBox_Teiler.Text += Convert.ToString(i) + "\r\n";
                }

                //Um eins erhöhen
                i++;
            }
        }

        private void button_beenden_Click(object sender, EventArgs e)
        {
            //Das Programm beenden
            this.Close();
        }
    }
}
