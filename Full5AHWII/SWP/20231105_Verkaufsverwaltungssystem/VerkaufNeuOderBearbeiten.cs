using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231105_Verkaufsverwaltungssystem
{
    public partial class VerkaufNeuOderBearbeiten : Form
    {
        private SqlConnection _SQLConnection;

        private SqlDataAdapter _SQLDataAdapterVerkauf;
        private SqlCommand _SQLCommandVerkauf;
        private DataSet _DataSetVerkauf;
        private BindingSource _BindingSourceVerkauf;

        private SqlDataAdapter _SQLDataAdapterKundennummer;
        private SqlCommand _SQLCommandKundennummer;
        private DataSet _DataSetKundennummer;
        private BindingSource _BindingSourceKunde;

        private SqlDataAdapter _SQLDataAdapterProdukt;
        private SqlCommand _SQLCommandProdukt;
        private DataSet _DataSetProdukt;
        private BindingSource _BindingSourceProdukt;

        private SqlCommand _SQLCommandVerkaufInsert;

        public VerkaufNeuOderBearbeiten()
        {
            InitializeComponent();

            //Create Database Connection
            _SQLConnection = new SqlConnection(DataBaseInfo.ConnectionString);

            //Get the data into the dataset
            _SQLDataAdapterVerkauf = new SqlDataAdapter();
            _SQLCommandVerkauf = new SqlCommand("SELECT * FROM Verkauf;", _SQLConnection);
            _SQLDataAdapterVerkauf.SelectCommand = _SQLCommandVerkauf;
            _DataSetVerkauf = new DataSet();
            _SQLDataAdapterVerkauf.FillSchema(_DataSetVerkauf, SchemaType.Source, "Verkauf");
            _SQLDataAdapterVerkauf.Fill(_DataSetVerkauf, "Verkauf");
            _BindingSourceVerkauf = new BindingSource();
            _BindingSourceVerkauf.DataSource = _DataSetVerkauf;
            _BindingSourceVerkauf.DataMember = "Verkauf";
            _BindingSourceVerkauf.DataSource = _DataSetVerkauf.Tables["Verkauf"];

            _SQLDataAdapterKundennummer = new SqlDataAdapter();
            _SQLCommandKundennummer = new SqlCommand("SELECT * FROM Kunde;", _SQLConnection);
            _SQLDataAdapterKundennummer.SelectCommand = _SQLCommandKundennummer;
            _DataSetKundennummer = new DataSet();
            _SQLDataAdapterKundennummer.FillSchema(_DataSetKundennummer, SchemaType.Source, "Kunde");
            _SQLDataAdapterKundennummer.Fill(_DataSetKundennummer, "Kunde");
            _BindingSourceKunde = new BindingSource();
            _BindingSourceKunde.DataSource = _DataSetKundennummer;
            _BindingSourceKunde.DataMember = "Kunde";
            _BindingSourceKunde.DataSource = _DataSetKundennummer.Tables["Kunde"];

            _SQLDataAdapterProdukt = new SqlDataAdapter();
            _SQLCommandProdukt = new SqlCommand("SELECT * FROM Produkt;", _SQLConnection);
            _SQLDataAdapterProdukt.SelectCommand = _SQLCommandProdukt;
            _DataSetProdukt = new DataSet();
            _SQLDataAdapterProdukt.FillSchema(_DataSetProdukt, SchemaType.Source, "Produkt");
            _SQLDataAdapterProdukt.Fill(_DataSetProdukt, "Produkt");
            _BindingSourceProdukt = new BindingSource();
            _BindingSourceProdukt.DataSource = _DataSetProdukt;
            _BindingSourceProdukt.DataMember = "Produkt";
            _BindingSourceProdukt.DataSource = _DataSetProdukt.Tables["Produkt"];

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

            //Add the InsertCommand for Verkauf
            _SQLCommandVerkaufInsert = new SqlCommand("INSERT INTO Verkauf (PRODUKT_ID, KDN_ID, DATUM, MENGE) VALUES (@PRODUKT_ID, @KDN_ID, @DATUM, @MENGE)", _SQLConnection);
            _SQLCommandVerkaufInsert.Parameters.Add("@PRODUKT_ID", SqlDbType.Int, 32, "PRODUKT_ID");
            _SQLCommandVerkaufInsert.Parameters.Add("@KDN_ID", SqlDbType.Int, 32, "KDN_ID");
            _SQLCommandVerkaufInsert.Parameters.Add("@MENGE", SqlDbType.Float, 32, "MENGE");
            _SQLCommandVerkaufInsert.Parameters.Add("@DATUM", SqlDbType.DateTime, 32, "DATUM");
            _SQLDataAdapterVerkauf.InsertCommand = _SQLCommandVerkaufInsert;

            //Start editing
            _BindingSourceVerkauf.AddNew();
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
            _SQLDataAdapterVerkauf.Update(_DataSetVerkauf, "Verkauf");

            //Fenster schließen
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //Fenster schließen
            this.Close();
        }
    }
}
