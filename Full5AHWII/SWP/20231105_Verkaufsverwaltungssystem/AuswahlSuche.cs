using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231105_Verkaufsverwaltungssystem
{
    public partial class AuswahlSuche : Form
    {
        private int _PositionBeforeChange;
        private BindingSource _BindingSource;

        public AuswahlSuche(BindingSource EnteredBindingSource)
        {
            InitializeComponent();

            //Add the BindingSource to the class
            _BindingSource = EnteredBindingSource;

            //Get the position before changing anything
            _PositionBeforeChange = _BindingSource.Position;

            //Fill the datagridview with the table
            dataGridView_Auswahl.DataSource = _BindingSource;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            //Close the window
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //Reset the positon
            _BindingSource.Position = _PositionBeforeChange;

            //Close the window
            this.Close();
        }
    }
}
