using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231105_Verkaufsverwaltungssystem
{
    public partial class VerkaufNeuOderBearbeiten : Form
    {
        private BindingSource _BindingSourceVerkauf;
        private BindingSource _BindingSourceKunde;
        private BindingSource _BindingSourceProdukt;

        public VerkaufNeuOderBearbeiten(BindingSource BindingSourceVerkauf, BindingSource BindingSourceKunde, BindingSource BindingSourceProdukt, bool EditMode)
        {
            InitializeComponent();

            //Get the parameters
            _BindingSourceVerkauf = BindingSourceVerkauf;
            _BindingSourceKunde = BindingSourceKunde;
            _BindingSourceProdukt = BindingSourceProdukt;

            //Fill the comboboxes
            comboBox_Kundenummer.DataSource = _BindingSourceKunde;
            comboBox_Kundenummer.DisplayMember = "Nachname";
            comboBox_Kundenummer.ValueMember = "KDN_ID";

            comboBox_Produkt.DataSource = _BindingSourceProdukt;
            comboBox_Produkt.DisplayMember = "PName";
            comboBox_Produkt.ValueMember = "Produkt_ID";

            //Add the textboxes to the BindingData
            comboBox_Kundenummer.DataBindings.Add("SelectedValue", _BindingSourceVerkauf, "KDN_ID");
            if(comboBox_Kundenummer.Items.Count > 0)
            {
                comboBox_Kundenummer.SelectedIndex = 0;
            }
            comboBox_Produkt.DataBindings.Add("SelectedValue", _BindingSourceVerkauf, "Produkt_ID");
            if (comboBox_Produkt.Items.Count > 0)
            {
                comboBox_Produkt.SelectedIndex = 0;
            }
            textBox_Menge.DataBindings.Add("Text", _BindingSourceVerkauf, "MENGE");
            textBox_Datum.DataBindings.Add("Text", _BindingSourceVerkauf, "DATUM");

            if(EditMode == false)
            {
                //Start editing
                _BindingSourceVerkauf.AddNew();
            }
        }

        private void button_KundennummerSuchen_Click(object sender, EventArgs e)
        {
            AuswahlSuche AS = new AuswahlSuche(_BindingSourceKunde);
            AS.ShowDialog();
        }

        private void button_ProduktSuchen_Click(object sender, EventArgs e)
        {
            AuswahlSuche AS = new AuswahlSuche(_BindingSourceProdukt);
            AS.ShowDialog();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            //Editieren beenden und Tabelle updaten
            _BindingSourceVerkauf.EndEdit();

            //Fenster schließen
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //Fenster schließen
            _BindingSourceVerkauf.CancelEdit();
            this.Close();
        }
    }
}
