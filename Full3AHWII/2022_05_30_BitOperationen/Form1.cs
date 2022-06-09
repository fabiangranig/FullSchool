using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220530_BitOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Operators(string op)
        {
            //Die Nummer aus der Textbox holen
            uint a = Convert.ToUInt32(Convert.ToString(txtBox_zahl1.Text));
            uint b = Convert.ToUInt32(Convert.ToString(txtBox_zahl2.Text));
            uint sol = 0;

            //Den Operator benutzen
            if(op == "~")
            {
                sol = ~a;
            }
            if(op == "|")
            {
                sol = a | b;
            }
            if (op == "&")
            {
                sol = a & b;
            }
            if (op == ">>")
            {
                sol = a >> Convert.ToInt32(b);
            }
            if (op == "<<")
            {
                sol = a << Convert.ToInt32(b);
            }

            //Die Lösung anzeigen
            txtBox_ergebnis.Text = Convert.ToString(sol);
        }

        private void btn_Legieren_Click(object sender, EventArgs e)
        {
            Operators("~");
        }

        private void btn_oder_Click(object sender, EventArgs e)
        {
            Operators("|");
        }

        private void btn_und_Click(object sender, EventArgs e)
        {
            Operators("&");
        }

        private void btn_rechts_Click(object sender, EventArgs e)
        {
            Operators(">>");
        }

        private void btn_links_Click(object sender, EventArgs e)
        {
            Operators("<<");
        }
    }
}
