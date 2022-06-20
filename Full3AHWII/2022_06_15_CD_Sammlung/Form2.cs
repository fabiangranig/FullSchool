using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220615_CD_Sammlung
{
    public partial class Form2 : Form
    {
        public bool schalter = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            schalter = true;
            this.Close();
        }

        private void btn_nichtok_Click(object sender, EventArgs e)
        {
            schalter = false;
            this.Close();
        }
    }
}
