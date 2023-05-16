using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230515_Dialog_Datenuebergabe
{
    public partial class Unterformular : Form
    {
        public string Aenderungstext
        {
            get { return txt_Unterformular.Text; }
            set { txt_Unterformular.Text = value; }
        }

        public Unterformular()
        {
            InitializeComponent();
        }

        public Unterformular(string input)
        {
            InitializeComponent();
            this.txt_Unterformular.Text = input;
        }
    }
}
