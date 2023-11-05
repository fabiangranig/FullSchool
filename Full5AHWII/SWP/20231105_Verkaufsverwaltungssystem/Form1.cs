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
using System.Xml.Serialization;

namespace _20231105_Verkaufsverwaltungssystem
{
    public partial class Form1 : Form
    {
        private SqlConnection _SQLConnection;

        private SqlDataAdapter _SQLDataAdapterVerkauf;
        private SqlCommand _SQLCommandVerkauf;
        private DataSet _DataSetVerkauf;
        private BindingSource _BindingSourceVerkauf;
        private SqlCommand _SQLCommandVerkaufInsert;

        private SqlDataAdapter _SQLDataAdapterKundennummer;
        private SqlCommand _SQLCommandKundennummer;
        private DataSet _DataSetKundennummer;
        private BindingSource _BindingSourceKunde;

        private SqlDataAdapter _SQLDataAdapterProdukt;
        private SqlCommand _SQLCommandProdukt;
        private DataSet _DataSetProdukt;
        private BindingSource _BindingSourceProdukt;

        public Form1()
        {
            InitializeComponent();

            //Create Database Connection
            _SQLConnection = new SqlConnection(DataBaseInfo.ConnectionString);

            //Create objects for the different tables
            CreateTableVerkaufObjects();
            CreateTableKundeObjects();
            CreateTableProduktObjects();

            //Connect BindingSource to DataGridView
            dataGridView_MainScreen.DataSource = _BindingSourceVerkauf;
        }

        private void CreateTableVerkaufObjects()
        {
            //Get the data into the dataset
            _SQLDataAdapterVerkauf = new SqlDataAdapter();
            _SQLCommandVerkauf = new SqlCommand("SELECT p.Produkt_ID, p.PName, v.KDN_ID, v.Datum, v.Menge, p.Preis, p.Preis * v.Menge as Verkaufspreis FROM Verkauf v, Produkt p WHERE v.Produkt_ID = p.Produkt_ID;", _SQLConnection);
            _SQLDataAdapterVerkauf.SelectCommand = _SQLCommandVerkauf;
            _DataSetVerkauf = new DataSet();
            _SQLDataAdapterVerkauf.FillSchema(_DataSetVerkauf, SchemaType.Source, "Verkauf");
            _SQLDataAdapterVerkauf.Fill(_DataSetVerkauf, "Verkauf");
            _BindingSourceVerkauf = new BindingSource();
            _BindingSourceVerkauf.DataSource = _DataSetVerkauf;
            _BindingSourceVerkauf.DataMember = "Verkauf";
            _BindingSourceVerkauf.DataSource = _DataSetVerkauf.Tables["Verkauf"];

            //Add the InsertCommand for Verkauf
            _SQLCommandVerkaufInsert = new SqlCommand("INSERT INTO Verkauf (PRODUKT_ID, KDN_ID, DATUM, MENGE) VALUES (@PRODUKT_ID, @KDN_ID, @DATUM, @MENGE)", _SQLConnection);
            _SQLCommandVerkaufInsert.Parameters.Add("@PRODUKT_ID", SqlDbType.Int, 32, "PRODUKT_ID");
            _SQLCommandVerkaufInsert.Parameters.Add("@KDN_ID", SqlDbType.Int, 32, "KDN_ID");
            _SQLCommandVerkaufInsert.Parameters.Add("@MENGE", SqlDbType.Float, 32, "MENGE");
            _SQLCommandVerkaufInsert.Parameters.Add("@DATUM", SqlDbType.DateTime, 32, "DATUM");
            _SQLDataAdapterVerkauf.InsertCommand = _SQLCommandVerkaufInsert;
        }

        private void CreateTableKundeObjects()
        {
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
        }

        private void CreateTableProduktObjects()
        {
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
        }

        private void button_VerkaufNeu_Click(object sender, EventArgs e)
        {
            VerkaufNeuOderBearbeiten VK = new VerkaufNeuOderBearbeiten(_BindingSourceVerkauf, _BindingSourceKunde, _BindingSourceProdukt);
            VK.ShowDialog();
            _SQLDataAdapterVerkauf.Update(_DataSetVerkauf, "Verkauf");
            _BindingSourceVerkauf.ResetBindings(false);
        }
    }
}
