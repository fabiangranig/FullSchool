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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Datenuebergabe_Click(object sender, EventArgs e)
        {
            Unterformular UF = new Unterformular(txtBox_Hauptformular.Text);
            //UF.Aenderungstext = "Hallo";
            DialogResult result = UF.ShowDialog();

            if(result == DialogResult.OK)
            {
                this.txtBox_Hauptformular.Text = UF.Aenderungstext;
            }
        }
    }
}
