using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230508_bewegterText
{
    public partial class TextAendernUntermenue : Form
    {
        public string Aenderungstext
        {
            get { return textBox_Feld.Text; }
            set { textBox_Feld.Text = value; }
        }

        public TextAendernUntermenue()
        {
            InitializeComponent();
        }

        public TextAendernUntermenue(string input)
        {
            InitializeComponent();
            Aenderungstext = input;
        }
    }
}
