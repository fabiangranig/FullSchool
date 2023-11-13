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
        private SqlCommand _SQLCommandVerkaufUpdate;
        private SqlCommand _SQLCommandVerkaufDelete;

        private SqlDataAdapter _SQLDataAdapterKunden;
        private SqlCommand _SQLCommandKundennummer;
        private DataSet _DataSetKundennummer;
        private BindingSource _BindingSourceKunde;
        private SqlCommand _SQLCommandKundeInsert;
        private SqlCommand _SQLCommandKundeDelete;

        private SqlDataAdapter _SQLDataAdapterProdukt;
        private SqlCommand _SQLCommandProdukt;
        private DataSet _DataSetProdukt;
        private BindingSource _BindingSourceProdukt;
        private SqlCommand _SQLCommandProduktInsert;
        private SqlCommand _SQLCommandProduktDelete;

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

            //Update command
            _SQLCommandVerkaufUpdate = new SqlCommand("UPDATE VERKAUF SET PRODUKT_ID = @PRODUKT_ID, KDN_ID = @KDN_ID, MENGE = @Menge WHERE DATUM = @DATUM;", _SQLConnection);
            _SQLCommandVerkaufUpdate.Parameters.Add("@PRODUKT_ID", SqlDbType.Int, 32, "PRODUKT_ID");
            _SQLCommandVerkaufUpdate.Parameters.Add("@KDN_ID", SqlDbType.Int, 32, "KDN_ID");
            _SQLCommandVerkaufUpdate.Parameters.Add("@MENGE", SqlDbType.Float, 32, "MENGE");
            _SQLCommandVerkaufUpdate.Parameters.Add("@DATUM", SqlDbType.DateTime, 32, "DATUM");
            _SQLDataAdapterVerkauf.UpdateCommand = _SQLCommandVerkaufUpdate;

            //Delete command
            _SQLCommandVerkaufDelete = new SqlCommand("DELETE FROM VERKAUF WHERE Datum = @Datum;", _SQLConnection);
            _SQLCommandVerkaufDelete.Parameters.Add("@DATUM", SqlDbType.DateTime, 32, "DATUM");
            _SQLDataAdapterVerkauf.DeleteCommand = _SQLCommandVerkaufDelete;
        }

        private void CreateTableKundeObjects()
        {
            _SQLDataAdapterKunden = new SqlDataAdapter();
            _SQLCommandKundennummer = new SqlCommand("SELECT * FROM Kunde;", _SQLConnection);
            _SQLDataAdapterKunden.SelectCommand = _SQLCommandKundennummer;
            _DataSetKundennummer = new DataSet();
            _SQLDataAdapterKunden.FillSchema(_DataSetKundennummer, SchemaType.Source, "Kunde");
            _SQLDataAdapterKunden.Fill(_DataSetKundennummer, "Kunde");
            _BindingSourceKunde = new BindingSource();
            _BindingSourceKunde.DataSource = _DataSetKundennummer;
            _BindingSourceKunde.DataMember = "Kunde";
            _BindingSourceKunde.DataSource = _DataSetKundennummer.Tables["Kunde"];

            //Add the InsertCommand for Produkt
            _SQLCommandKundeInsert = new SqlCommand("INSERT INTO Kunde (KDN_ID, Nachname, Vorname, PLZ, Adresse) VALUES (@KDN_ID, @Nachname, @Vorname, @PLZ, @Adresse)", _SQLConnection);
            _SQLCommandKundeInsert.Parameters.Add("@KDN_ID", SqlDbType.Int, 32, "KDN_ID");
            _SQLCommandKundeInsert.Parameters.Add("@Nachname", SqlDbType.Text, 32, "Nachname");
            _SQLCommandKundeInsert.Parameters.Add("@Vorname", SqlDbType.Text, 32, "Vorname");
            _SQLCommandKundeInsert.Parameters.Add("@PLZ", SqlDbType.Int, 32, "PLZ");
            _SQLCommandKundeInsert.Parameters.Add("@Adresse", SqlDbType.Text, 32, "Adresse");
            _SQLDataAdapterKunden.InsertCommand = _SQLCommandKundeInsert;

            //Delete command
            _SQLCommandKundeDelete = new SqlCommand("DELETE FROM Kunde WHERE KDN_ID = @KDN_ID;", _SQLConnection);
            _SQLCommandKundeDelete.Parameters.Add("@KDN_ID", SqlDbType.Int, 32, "KDN_ID");
            _SQLDataAdapterKunden.DeleteCommand = _SQLCommandKundeDelete;
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

            //Add the InsertCommand for Produkt
            _SQLCommandProduktInsert = new SqlCommand("INSERT INTO Produkt (PRODUKT_ID, PName, Preis) VALUES (@PRODUKT_ID, @PNAME, @PREIS)", _SQLConnection);
            _SQLCommandProduktInsert.Parameters.Add("@PRODUKT_ID", SqlDbType.Int, 32, "PRODUKT_ID");
            _SQLCommandProduktInsert.Parameters.Add("@PNAME", SqlDbType.Text, 32, "PNAME");
            _SQLCommandProduktInsert.Parameters.Add("@PREIS", SqlDbType.Float, 32, "PREIS");
            _SQLDataAdapterProdukt.InsertCommand = _SQLCommandProduktInsert;

            //Delete command
            _SQLCommandProduktDelete = new SqlCommand("DELETE FROM Produkt WHERE Produkt_ID = @PRODUKT_ID;", _SQLConnection);
            _SQLCommandProduktDelete.Parameters.Add("@PRODUKT_ID", SqlDbType.Int, 32, "PRODUKT_ID");
            _SQLDataAdapterProdukt.DeleteCommand = _SQLCommandProduktDelete;
        }

        private void button_VerkaufNeu_Click(object sender, EventArgs e)
        {
            VerkaufNeuOderBearbeiten VK = new VerkaufNeuOderBearbeiten(_BindingSourceVerkauf, _BindingSourceKunde, _BindingSourceProdukt, false);
            VK.ShowDialog();
            _SQLDataAdapterVerkauf.Update(_DataSetVerkauf, "Verkauf");

            _DataSetVerkauf.Tables["Verkauf"].Clear();
            _SQLDataAdapterVerkauf.FillSchema(_DataSetVerkauf, SchemaType.Source, "Verkauf");
            _SQLDataAdapterVerkauf.Fill(_DataSetVerkauf, "Verkauf");
        }

        private void button_Bearbeiten_Click(object sender, EventArgs e)
        {
            VerkaufNeuOderBearbeiten VK = new VerkaufNeuOderBearbeiten(_BindingSourceVerkauf, _BindingSourceKunde, _BindingSourceProdukt, true);
            VK.ShowDialog();
            _SQLDataAdapterVerkauf.Update(_DataSetVerkauf, "Verkauf");

            _DataSetVerkauf.Tables["Verkauf"].Clear();
            _SQLDataAdapterVerkauf.FillSchema(_DataSetVerkauf, SchemaType.Source, "Verkauf");
            _SQLDataAdapterVerkauf.Fill(_DataSetVerkauf, "Verkauf");
        }

        private void button_Stornieren_Click(object sender, EventArgs e)
        {
            if (_BindingSourceVerkauf.Current != null)
            {
                _BindingSourceVerkauf.RemoveCurrent();
                _SQLDataAdapterVerkauf.Update(_DataSetVerkauf, "Verkauf");
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }

        private void button_KundeWarten_Click(object sender, EventArgs e)
        {
            string[] ColumnNames = { "KDN_ID", "Nachname", "Vorname", "PLZ", "Adresse" };
            ObjektWarten OW = new ObjektWarten("Kunde", ColumnNames, ref _DataSetKundennummer, _SQLDataAdapterKunden, _BindingSourceKunde);
            OW.ShowDialog();
        }

        private void button_ProduktWarten_Click(object sender, EventArgs e)
        {
            string[] ColumnNames = { "Produkt_ID", "PName", "Preis" };
            ObjektWarten OW = new ObjektWarten("Produkt", ColumnNames, ref _DataSetProdukt, _SQLDataAdapterProdukt, _BindingSourceProdukt);
            OW.ShowDialog();
        }
    }
}
